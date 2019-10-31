using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJackDatabase.Repository_s
{
    public class UitslagRepository
    {
        
            SpelletjesEntities context = new SpelletjesEntities();
            SpelerRepository spelerRepository = new SpelerRepository();
            public void GetUitslag()
            {
                var uitslagen = context.Uitslagens;

                foreach (var uitslag in uitslagen)
                {
                    Console.WriteLine(uitslag.uitslag + "uitslag ID: " + uitslag.uitslag_id + " speler ID: " + uitslag.speler_id + " spel ID: " + uitslag.spel_id);
                }
            }
            
            public void AddUitslag(BlackJack.Speler speler, String uitslag)
            {
                int id = context.Spelers.Single(s => s.first_name == speler.Naam).speler_id;

                Uitslagen uitslagDB = new Uitslagen()
                    {
                        spel_id = 4,
                        uitslag = uitslag,
                        speler_id = id
                    };
                    context.Uitslagens.Add(uitslagDB);
                    context.SaveChanges();
                }
            }

    }
