using System;
using System.Collections.Generic;


namespace game.unit02_hilo

{
    public class Player
    {
        int Points;
        Deck deck = new Deck();
        int startcard;
        int endcard;
        //deck.GetNumber();




        public Player()
        {
            Points = 300;
            startcard = deck.GetNumber();
        }

        public void StartGame()
        {
            string answer = "";
            bool isplaying = true;

            while (isplaying)
            {
                Console.WriteLine($"The card is :{startcard}");
                Console.Write("Higher or lower? [h/l]");
                answer = Console.ReadLine();
                endcard = deck.GetNumber();
                Console.WriteLine($"The next card was :{endcard}");
                if ((answer == "H" || answer == "h") && endcard >= startcard)
                {
                    Points += 100;

                }

                else if ((answer == "L" || answer == "l") && endcard <= startcard)
                {

                    Points += 100;

                }
                else
                {
                    Points -= 75;
                }

                Console.WriteLine($"Your score is {Points}");

                Console.WriteLine("Play again? [y/n]");
                string ans = Console.ReadLine();
                if (ans == "N" || ans == "n")
                {
                    isplaying = false;
                }
                startcard = endcard;
            }

        }
    }
}