using FlashcardCreator.Entities;
using FlashcardCreator.Repositories;

namespace FlashcardCreator
{
    public partial class BrowseForm : Form
    {
        private readonly FlashcardRepository _repository;
        private int _currentPage = 1;
        private int _pageSize = 10;
        private int _totalFlashcards;
        private string _currentSearchTerm = "";
        private bool _sortAscending = true;

        public BrowseForm(FlashcardRepository repository)
        {
            InitializeComponent();
            _repository = repository;
            ConfigureDataGridView();
            LoadFlashcards();
            UpdatePaginationControls();
            dgvFlashcards.CellContentClick += dgvFlashcards_CellContentClick!;
        }

        private void ConfigureDataGridView()
        {
            dgvFlashcards.AutoGenerateColumns = false;
            dgvFlashcards.AllowUserToAddRows = false;
            dgvFlashcards.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFlashcards.MultiSelect = false;
            dgvFlashcards.ReadOnly = true;
            dgvFlashcards.RowHeadersVisible = false;

            dgvFlashcards.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "word",
                HeaderText = "Word",
                Width = 150
            });

            dgvFlashcards.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "answer",
                HeaderText = "Answer",
                Width = 150
            });

            dgvFlashcards.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                DataPropertyName = "learned",
                HeaderText = "Learned",
                Width = 80,
                ReadOnly = true
            });

            var learnedColumn = new DataGridViewButtonColumn()
            {
                Text = "Toggle Learned",
                UseColumnTextForButtonValue = true,
                HeaderText = "Mark Learned",
                Width = 120
            };
            dgvFlashcards.Columns.Add(learnedColumn);

            var deleteColumn = new DataGridViewButtonColumn()
            {
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                HeaderText = "Delete",
                Width = 80
            };
            dgvFlashcards.Columns.Add(deleteColumn);
        }

        private void LoadFlashcards()
        {
            try
            {
                var flashcards = _repository.GetFlashcards(
                    _currentPage,
                    _pageSize,
                    out _totalFlashcards,
                    _currentSearchTerm,
                    _sortAscending);

                dgvFlashcards.DataSource = flashcards;
                lblStatus.Text = $"Showing {((_currentPage - 1) * _pageSize) + 1}-{Math.Min(_currentPage * _pageSize, _totalFlashcards)} of {_totalFlashcards} flashcards";
            }
            catch { }
        }

        private void UpdatePaginationControls()
        {
            btnPrevious.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage * _pageSize < _totalFlashcards;
            lblStatus.Text = $"Page {_currentPage} of {(_totalFlashcards + _pageSize - 1) / _pageSize}";
        }

        private void dgvFlashcards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var flashcard = (Flashcard)dgvFlashcards.Rows[e.RowIndex].DataBoundItem;

            var toggleLearnedColumn = dgvFlashcards.Columns
                .Cast<DataGridViewColumn>()
                .FirstOrDefault(c => c.HeaderText == "Mark Learned");

            var deleteColumn = dgvFlashcards.Columns
                .Cast<DataGridViewColumn>()
                .FirstOrDefault(c => c.HeaderText == "Delete");

            if (toggleLearnedColumn != null && e.ColumnIndex == toggleLearnedColumn.Index)
            {
                ToggleLearnedStatus(flashcard, e.RowIndex);
            }
            else if (deleteColumn != null && e.ColumnIndex == deleteColumn.Index)
            {
                DeleteFlashcard(flashcard);
            }
        }


        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadFlashcards();
                UpdatePaginationControls();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentPage * _pageSize < _totalFlashcards)
            {
                _currentPage++;
                LoadFlashcards();
                UpdatePaginationControls();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numPageSize_ValueChanged(object sender, EventArgs e)
        {
            _pageSize = (int)numPageSize.Value;
            _currentPage = 1;
            LoadFlashcards();
            UpdatePaginationControls();
        }

        private void ToggleLearnedStatus(Flashcard flashcard, int rowIndex)
        {
            _repository.ToggleLearnedStatus(flashcard.Id);

            dgvFlashcards.InvalidateRow(rowIndex);
            LoadFlashcards();

        }

        private void DeleteFlashcard(Flashcard flashcard)
        {
            _repository.DeleteFlashcard(flashcard.Id);
            LoadFlashcards();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            _currentSearchTerm = searchTextBox.Text;
            _currentPage = 1;
            LoadFlashcards();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            _sortAscending = !_sortAscending;
            LoadFlashcards();
        }
    }
}
