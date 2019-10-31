using System;
using System.Collections;
using System.Collections.Generic;
using BlackJackDatabase.Repository_s;
namespace BlackJack
{
    class Program
    {
        static SpelerRepository blah = new SpelerRepository();
        static UitslagRepository uitslagDBO = new UitslagRepository();
        static void Main(string[] args)
        {
           Spelen.Spel();
           uitslagDBO.GetUitslag();
        }
        
    }
}