using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlesDickensÄventyr
{
    public static class Randomizer
    ///<summary>
    /// This class will randomize numbers, dropchance, and amount of damage. Very useful, much wow
    /// Keep in mind, it is a static class, meaning you can't create an object of this, it will always be available and active for you, bby
    /// 
    /// Programmers: Christopher Velander, Johan Danielsson, Patrik Hurtig
    /// 
    /// Date: 2018-03-21
    /// </summary>
    {
        private static Random randomize = new Random();

        public static int Numbers(int min, int max) // take in 2 numbers and get a random number inbetween
        {
            return randomize.Next(min, max + 1);
        }
    }
}
