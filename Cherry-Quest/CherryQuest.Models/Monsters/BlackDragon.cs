namespace CherryQuest.Models.Monsters
{
    using Models;

    public class BlackDragon : Monster
    {
        private const int BlackHealth = 180;
        private const int BlackAttack = 50;
        private const int BlackDefence = 50;

        public BlackDragon(string name, Position position, bool isAlive)
            : base(name, position, BlackHealth, BlackAttack, BlackDefence, isAlive)
        {
        }
    }
}
