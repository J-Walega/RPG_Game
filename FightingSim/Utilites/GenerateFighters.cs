using System.Collections.Generic;
using FightingSim.Fighters;

namespace FightingSim.Utilites
{
    public class GenerateFighters
    {
        private static Warrior firstFighter = new Warrior();
        private static Barbarian secondFighter = new Barbarian();
        private static Rogue thirdFighter = new Rogue();

        public static List<BaseFighter> Generate()
        {
            List<BaseFighter> fighters = new List<BaseFighter>
            {
                firstFighter,
                secondFighter,
                thirdFighter
            };

            return fighters;
        }
    }
}
