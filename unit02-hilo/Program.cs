using System;
using System.Collections.Generic;


namespace unit02_hilo
{
    public class Deck
    {
        public static void Main(string[] args){
            
        }
        int card;
    

        public Deck()
        {
        }

        public int GetNumber()
        {
           
            Random random = new Random();
            
            card = random.Next(1,14);

            return card;


        }
    }
}