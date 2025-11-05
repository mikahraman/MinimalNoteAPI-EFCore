using Microsoft.EntityFrameworkCore;

namespace MinimalNoteAPI
{

    public class NoteDb : DbContext
    {
        public NoteDb(DbContextOptions<NoteDb> options) : base(options) { }


        public DbSet<Note> Notes => Set<Note>();
    }
}