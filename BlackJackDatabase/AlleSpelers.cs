﻿using System;
using System.Collections.Generic;
using BlackJackDatabase.Repository_s;

namespace BlackJack
{
    public class AlleSpelers
    {
        public List<Speler> spelers { get; }
        SpelerRepository _spelerRepository = new SpelerRepository();
        public AlleSpelers(List<Speler> spelers)
        {
            spelers = spelers;
        }

        public void aantalSpelers(List<Speler> spelers)
        {
            Console.WriteLine("Met hoeveel mensen spelen we?");
            String invoerSpelers = Console.ReadLine();
            int mensen = Convert.ToInt16(invoerSpelers);
            for (int i = 1; i <= mensen; i++)
            {
                Console.WriteLine("Voer de naam van de speler " + i);
                String naam = Console.ReadLine();
                Speler speler = new Speler(naam, true, false, 0);
                spelers.Add(speler);
                if (_spelerRepository.ReadPlayer(speler) == false)
                {
                    _spelerRepository.AddSpeler(speler);
                }
            }

            Console.WriteLine("Dit zijn de spelers: ");
            foreach (Speler speler in spelers)
            {
                Console.WriteLine(speler.Naam);
            }
        }

        public Speler addDealer()
        {
            Speler speler = new Speler("Dealer", true, true, 0);
            return speler;
        }
        
        }
    }
