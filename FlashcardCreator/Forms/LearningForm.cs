using FlashcardCreator.Database;
using FlashcardCreator.Entities;
using FlashcardCreator.Repositories;

namespace FlashcardCreator;

public partial class LearningForm : Form
{
    public List<Flashcard> flashcards;
    public int numOfFlashcard;

    public LearningForm()
    {
        InitializeComponent();
        var repo = new FlashcardRepository(new FlashCardDbContext());
        flashcards = repo.GetUnlearnedFlashcards();

        numOfFlashcard = 0;

        if (flashcards.Any() && flashcards.Count > numOfFlashcard)
        {
            loadDataFromNextFlashcard();
        }
        else
        {
            MessageBox.Show("You don't have any flashcards yet :(");
            wordLabel.Text = "Empty";
            exampleLabel.Text = "Empty";
            descriptionLabel.Text = "Empty";
            answerLabel.Text = "Empty";
        }
    }

    public void loadDataFromNextFlashcard()
    {
        if (flashcards.Count > numOfFlashcard)
        {
            var flashcard = flashcards[numOfFlashcard];

            wordLabel.Text = flashcard.word;
            exampleLabel.Text = flashcard.example;
            descriptionLabel.Text = flashcard.description;
            answerLabel.Text = flashcard.answer;

            numOfFlashcard++;
        } else if (flashcards.Count == numOfFlashcard && flashcards.Count != 0)
        {
            numOfFlashcard = 0;
            loadDataFromNextFlashcard();
        }
        else
        {
            Close();
        }
    }

    private void answerButton_Click(object sender, EventArgs e)
    {
        descriptionLabel.Visible = true;
        answerLabel.Visible = true;
    }

    private void nextButton_Click(object sender, EventArgs e)
    {
        descriptionLabel.Visible = false;
        answerLabel.Visible = false;

        loadDataFromNextFlashcard();
    }
}

