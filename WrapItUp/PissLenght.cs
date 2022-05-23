using System.Collections.Generic;
using System;

namespace WrapItUp
{
    public class PissLenght
    {
        public Random pissVolume = new Random();
        public Random poopVolume = new Random();

        public Stack<int> pissMass = new Stack<int>();
        public Stack<int> poopMass = new Stack<int>();

        public int pissMax;
        public int pissLow;
        public int pain;
        public int morePain;

        public void LongPiss()
        {
            Console.WriteLine("Been storing for a while eh?");
            Console.WriteLine("*stream pouring down*");

            pissMax = pissVolume.Next(10, 16);

            Console.WriteLine("You just pissed " + pissMax + " litres.");

            pissMass.Push(pissMax);

            Console.WriteLine("The toilet currently has");

            foreach (int item in pissMass)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("combined litres of pee.");
        }

        public void ShortPiss()
        {
            Console.WriteLine("Just a quick one and done, respect.");
            Console.WriteLine("*some splashing*");

            pissLow = pissVolume.Next(1, 3);

            Console.WriteLine("You just pissed " + pissLow + " litres.");

            pissMass.Push(pissLow);

            Console.WriteLine("The toilet currently has");

            foreach (int item in pissMass)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("combined litres of pee.");
        }

        public void DubbleUp()
        {
            Console.WriteLine("Oh, it's that day.");
            Console.WriteLine("*painful moments later*");

            pain = pissVolume.Next(15, 21);
            morePain = poopVolume.Next(20, 26);

            Console.WriteLine("You just pissed " + pain + " litres");
            Console.WriteLine("and pooped " + morePain + " kilos.");

            pissMass.Push(pain);
            poopMass.Push(morePain);

            Console.WriteLine("The toilet currently has");

            foreach (int item in pissMass)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("combined litres of pee.");
            Console.WriteLine("And");

            foreach (int item in poopMass)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("combined kilos of poop.");
        }
    }
}