namespace CherryQuest.Models.Monsters
{
    using Models;
    using Enums;

    public class Efreet : Monster
    {
        private const int EfreetHealth = 80;
        private const int EfreetAttack = 45;
        private const int EfreetDefence = 25;

        public Efreet(string name, Position position, bool isAlive)
            : base(name, position, EfreetHealth, EfreetAttack, EfreetDefence, isAlive)
        {
        }
    }
}
