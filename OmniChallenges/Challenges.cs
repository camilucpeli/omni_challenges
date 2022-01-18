using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OmniChallenges
{
    public class Challenges
    {
        public static void Calculator()
        {

        }

        public static int HowManyBillboards(string letters)
        {
            var omnidrone = "omnidre";

            var ammountOfLetters = omnidrone.Select(character =>
            {
                var count = character == 'o' || character == 'n'
                    ? letters.Count(l => l == character) / 2
                    : letters.Count(l => l == character);
                return (character, count);
            });

            return ammountOfLetters.Min(min => min.count);
        }

        public static int HowManyTimes(double h, double f, double m)
        {
            // if factor is 1, height won't change, so it will bounce infinitely
            // also if the factor is higher than 1, it means the ball is gaining energy everytime it hits the floor,
            // so, even if m is higher than the initial h, eventually it will reach m and it will continue reaching it infinitely
            if (f >= 1) return -1;

            var count = 0;
            // we want to count how many time the ball bounces until it doesn't reach the "m" height anymore
            while (h >= m)
            {
                // down
                count++;

                // hits the floor
                h *= f;

                // goes up and reaches the "m" height
                if (h >= m) count++;
            }
           
            return count;
        }

        public static void HalfSplits()
        {

        }

        public static void ThemePark()
        {

        }
    }
}
