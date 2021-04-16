using FightingSim.Utilites;

namespace FightingSim
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = GenerateFighters.Generate();
            _ = new Fight(participants);
        }
    }
}
