using System.Data.Entity;

namespace LuahelpPastebin.Models
{
    public class PastebinContext : DbContext
    {
        public PastebinContext() : base("DefaultConnection")
        {
        
        }

        public DbSet<Language> Languages { get; set; } 
        public DbSet<Paste> Pastes { get; set; } 
    }
}