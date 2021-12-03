using System;
using Microsoft.EntityFrameworkCore;
namespace Santi.Federico._5h.PrimoEF.Models
{
    public class DBPersone: DbContext

    {   
        //Tabella di Persone
        public DbSet<Persona> Persone {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder opzioni)
        {
            opzioni.UseSqlite("Data Source = DbPersone.db");
        }
    }


}
