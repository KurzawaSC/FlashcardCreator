using FlashcardCreator.Entities;
using System.Data.Entity;

namespace FlashcardCreator.Database;

public class FlashCardDbContext : DbContext
{
    public FlashCardDbContext() : base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FlashCardDB;Integrated Security=True")  {}
    
    public DbSet<Flashcard> Flashcards { get; set; } = null!;

}
