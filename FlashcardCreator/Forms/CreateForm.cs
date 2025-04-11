using FlashcardCreator.Database;
using FlashcardCreator.Entities;
using FlashcardCreator.Repositories;

namespace FlashcardCreator;

public partial class CreateForm : Form
{
    public FlashcardRepository repo;
    public CreateForm()
    {
        InitializeComponent();
        repo = new FlashcardRepository(new FlashCardDbContext());
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        var newFlashcard = new Flashcard
        {
            word = wordTextBox.Text,
            example = exampleTextBox.Text,
            description = descriptionTextBox.Text,
            answer = answerTextBox.Text
        };

        repo.AddFlashcard(newFlashcard);

        MessageBox.Show("Flashcard added");

        wordTextBox.Text = "";
        exampleTextBox.Text = "";
        descriptionTextBox.Text = "";
        answerTextBox.Text = "";
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}
