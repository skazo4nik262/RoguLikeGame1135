using RoguLikeGame1135.Creatures;

namespace RoguLikeGame1135
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                new Room(new Player()).RunBattle();
            }
        }
    }
}
