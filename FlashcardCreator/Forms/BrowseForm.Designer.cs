namespace FlashcardCreator
{
    partial class BrowseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvFlashcards = new DataGridView();
            btnPrevious = new Button();
            btnNext = new Button();
            lblStatus = new Label();
            numPageSize = new NumericUpDown();
            searchButton = new Button();
            orderButton = new Button();
            searchLabel = new Label();
            searchTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFlashcards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPageSize).BeginInit();
            SuspendLayout();
            // 
            // dgvFlashcards
            // 
            dgvFlashcards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlashcards.Location = new Point(12, 12);
            dgvFlashcards.Name = "dgvFlashcards";
            dgvFlashcards.RowHeadersWidth = 51;
            dgvFlashcards.Size = new Size(563, 287);
            dgvFlashcards.TabIndex = 0;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(195, 302);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 35);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "Previous";
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(276, 302);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 35);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.Click += btnNext_Click;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(195, 343);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(126, 23);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status: ";
            // 
            // numPageSize
            // 
            numPageSize.Location = new Point(367, 307);
            numPageSize.Name = "numPageSize";
            numPageSize.Size = new Size(121, 27);
            numPageSize.TabIndex = 4;
            numPageSize.ValueChanged += numPageSize_ValueChanged;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(12, 373);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(125, 29);
            searchButton.TabIndex = 5;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // orderButton
            // 
            orderButton.Location = new Point(195, 373);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(126, 29);
            orderButton.TabIndex = 6;
            orderButton.Text = "Switch order";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(12, 317);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(53, 20);
            searchLabel.TabIndex = 7;
            searchLabel.Text = "Search";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 343);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(125, 27);
            searchTextBox.TabIndex = 8;
            // 
            // BrowseForm
            // 
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(581, 411);
            Controls.Add(searchTextBox);
            Controls.Add(searchLabel);
            Controls.Add(orderButton);
            Controls.Add(searchButton);
            Controls.Add(dgvFlashcards);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(lblStatus);
            Controls.Add(numPageSize);
            Name = "BrowseForm";
            Text = "Browse Flashcards";
            ((System.ComponentModel.ISupportInitialize)dgvFlashcards).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPageSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFlashcards;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.NumericUpDown numPageSize;
        private Button searchButton;
        private Button orderButton;
        private Label searchLabel;
        private TextBox searchTextBox;
    }
}
