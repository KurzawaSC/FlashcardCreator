using FlashcardCreator.Database;
using FlashcardCreator.Entities;
using System.Data.Entity;

namespace FlashcardCreator.Repositories
{
    public class FlashcardRepository : IDisposable
    {
        private readonly FlashCardDbContext _db;
        private bool _disposed = false;

        public FlashcardRepository(FlashCardDbContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }
        public List<Flashcard> fetchAllFlashcards()
        {
            return _db.Flashcards.AsNoTracking().ToList();
        }
        public bool AddFlashcard(Flashcard flashcard)
        {
            try
            {
                _db.Flashcards.Add(flashcard);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Flashcard> GetFlashcards(int pageNumber, int pageSize, out int totalCount)
        {
            totalCount = _db.Flashcards.Count();
            return _db.Flashcards
                .OrderBy(f => f.word)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToList();
        }
        public List<Flashcard> GetUnlearnedFlashcards()
        {
            return _db.Flashcards
                .Where(f => !f.learned)
                .OrderBy(f => f.word)
                .AsNoTracking()
                .ToList();
        }

        public void DeleteFlashcard(int id)
        {
            try
            {
                var flashcard = _db.Flashcards.Find(id);

                _db.Flashcards.Remove(flashcard!);
                _db.SaveChanges();
            }
            catch
            {
            }
        }

        public void ToggleLearnedStatus(int id)
        {
            try
            {
                var flashcard = _db.Flashcards.Find(id);

                flashcard.learned = !flashcard.learned;
                _db.SaveChanges();
            }
            catch
            {
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _db?.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public List<Flashcard> SearchFlashcardsByWord(string searchTerm, bool sortAscending = true)
        {
            var query = _db.Flashcards.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(f => f.word.Contains(searchTerm));
            }

            // Sorting by word
            query = sortAscending ?
                query.OrderBy(f => f.word) :
                query.OrderByDescending(f => f.word);

            return query.AsNoTracking().ToList();
        }

        public List<Flashcard> GetFlashcards(int pageNumber, int pageSize, out int totalCount,
                                           string searchTerm = "", bool sortAscending = true)
        {
            var query = _db.Flashcards.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(f => f.word.Contains(searchTerm));
            }

            totalCount = query.Count();

            query = sortAscending ?
                query.OrderBy(f => f.word) :
                query.OrderByDescending(f => f.word);

            return query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToList();
        }
    }
}