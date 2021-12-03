using System;
using Santi.Federico._5h.PrimoEF.Models;
namespace Santi.Federico._5h.PrimoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello DatabaseWorld!");

            //apro il db
            DBPersone db = new();

            //aggiungiamo una persona alla tabella
            for(int i= 0;i<50;i++ )
            {
            db.Persone.Add(new Persona{Nome = "mamma",Cognome= "mia",Email="bronzmodz@gmail.com"});
            
            }
            db.SaveChanges();

        }
    }
}
