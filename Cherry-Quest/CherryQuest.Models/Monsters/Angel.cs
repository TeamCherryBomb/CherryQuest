namespace CherryQuest.Models.Monsters
{
    using Models;
    using Enums;

    public class Angel : Monster
    {
        private const int AngelHealth = 200;
        private const int AngelAttack = 50;
        private const int AngelDefence = 50;

        public Angel(string name, Position position, bool isAlive)
            : base(name, position, AngelHealth, AngelAttack, AngelDefence, isAlive)
        {
        }

    }
}
