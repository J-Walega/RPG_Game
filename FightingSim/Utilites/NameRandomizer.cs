using System;
using System.Collections.Generic;
using System.Text;

namespace FightingSim.Utilites
{
    public static class NameRandomizer
    {
        public static string RandomName()
        {
            Random random = new Random();
            string[] names = new string[] { "Aislinn", "Alys", "Avalon", "Boudicca", "Brianna", "Brighid", "Deidre" };

            int index = random.Next(names.Length);
            string name = names[index];

            return name;
        }
    }
}
