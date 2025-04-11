namespace FlashcardCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixModelChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Flashcards", "word", c => c.String());
            AddColumn("dbo.Flashcards", "example", c => c.String());
            AddColumn("dbo.Flashcards", "description", c => c.String());
            AddColumn("dbo.Flashcards", "answer", c => c.String());
            AddColumn("dbo.Flashcards", "date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Flashcards", "learned", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Flashcards", "learned");
            DropColumn("dbo.Flashcards", "date");
            DropColumn("dbo.Flashcards", "answer");
            DropColumn("dbo.Flashcards", "description");
            DropColumn("dbo.Flashcards", "example");
            DropColumn("dbo.Flashcards", "word");
        }
    }
}
