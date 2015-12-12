namespace CherryQuest.Models.Monsters
{
    using Models;
    using Enums;

    public class Basilisk : Monster
    {
        private const int BasiliskHealth = 80;
        private const int BasiliskAttack = 25;
        private const int BasiliskDefence = 25;

        public Basilisk(string name, Position position, bool isAlive)
            : base(name, position, BasiliskHealth, BasiliskAttack, BasiliskDefence, isAlive)
        {

        }
    }
}
