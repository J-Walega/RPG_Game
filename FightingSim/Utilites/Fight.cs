using System;
using System.Collections.Generic;
using System.Linq;
using FightingSim.Fighters;

namespace FightingSim.Utilites
{
    public class Fight
    {
        private int participants;
        private BaseFighter looser;
        public Fight(List<BaseFighter> fighters)
        {
            Battle(fighters);
        }

        private void Battle(List<BaseFighter> fighters)
        {
            foreach (BaseFighter names in fighters)
            {
                Console.WriteLine($"{names.Name}  HP:{names.HitPoints} -{names.Profession}");          
            }
            participants = fighters.Count;
            Console.WriteLine("Participants: " + participants);
            
            if(participants != 1)
            {
                var first = fighters.FirstOrDefault();
                var second = fighters.ElementAtOrDefault(1);

                int firstIndex = fighters.IndexOf(first);
                int secondIndex = fighters.IndexOf(second);

                Clash(first, second);
            }
            else
            {
                var winner = fighters.FirstOrDefault();
                DeclareWinner(winner);
            }
        }

        private BaseFighter Clash(BaseFighter first, BaseFighter second)
        {

            Console.WriteLine($"{first.Name} vs. {second.Name}");

            if(first.HitPoints < 1)
            {
                looser = first;
            }

            if(second.HitPoints < 1)
            {
                looser = second;
            }

            return looser;
        }

        private void DeclareWinner(BaseFighter winner)
        {
            Console.WriteLine($"The winner is: {winner.Name}");
        }
    }
}
