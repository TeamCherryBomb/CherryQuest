namespace CherryQuest.Models.Monsters
{
    using Models;
    using Enums;

    public class Goblin : Monster
    {
        private const int GoblinHealth = 30;
        private const int GoblinAttack = 10;
        private const int GoblinDefence = 7;

        public Goblin(string name, Position position, bool isAlive)
            : base(name, position, GoblinHealth, GoblinAttack, GoblinDefence, isAlive)
        {
        }
    }
}