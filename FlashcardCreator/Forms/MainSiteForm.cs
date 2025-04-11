using FlashcardCreator.Database;
using FlashcardCreator.Repositories;

namespace FlashcardCreator;

public partial class mainSiteForm : Form
{

    public mainSiteForm()
    {
        InitializeComponent();
    }

    private void learningButton_Click(object sender, EventArgs e)
    {
        var learningForm = new LearningForm();
        learningForm.Show();
    }

    private void createFlashcardButton_Click(object sender, EventArgs e)
    {
        var createForm = new CreateForm();
        createForm.Show();
    }

    private void browseButton_Click(object sender, EventArgs e)
    {
        using (var db = new FlashCardDbContext())
        using (var repository = new FlashcardRepository(db))
        {
            var browserForm = new BrowseForm(repository);
            browserForm.ShowDialog();
        }
    }
}
