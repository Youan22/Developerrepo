using System;

using System.Collections.Generic;


namespace game.unit02_hilo

{
    public class Card
    {
      
            
        int value;
    

        public Card()
        {
        }

        public int GetNumber()
        {
           
            Random random = new Random();
            
            value = random.Next(1,14);

            return value;


        }
    }
}
