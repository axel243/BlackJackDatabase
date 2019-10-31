using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDatabase.Repository_s
{
  
    public class SpelerRepository 
    {
        static SpelletjesEntities context = new SpelletjesEntities();
        List<String> spelernamen = new List<string>();
        static DbSet<Speler> spelers = context.Spelers;
        public int speler_id { get; }

        public void GetAllSpelers()
        {
            foreach (var speler in spelers)
            {
                Console.WriteLine(speler.first_name + " | " + speler.last_name + " | " + speler.speler_id);
            }
        }

        public bool ReadPlayer(BlackJack.Speler speler)
        {
            bool spelerBestaat = false;
            foreach (var spelerDB in spelers)
            {
                if (spelerDB.first_name == speler.Naam)
                {
                    spelerBestaat = true;
                    break;
                }
            }
            return spelerBestaat;
        }

        public void AddSpeler(BlackJack.Speler speler)
        {
            Speler spelerDB = new Speler()
            {
            first_name = speler.Naam
            };
            context.Spelers.Add(spelerDB);
            context.SaveChanges();
        }
    }
}
