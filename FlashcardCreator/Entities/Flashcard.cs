using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FlashcardCreator.Entities;

public class Flashcard
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string word { get; set; } = default!;
    public string example { get; set; } = default!;
    public string description { get; set; } = default!;
    public string answer { get; set; } = default!;
    public DateTime date { get; set; } = DateTime.Now;
    public bool learned { get; set;} = false;
}
