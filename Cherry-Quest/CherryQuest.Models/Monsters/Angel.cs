namespace TW.Monsters
{
    using Enums;
    using Interfaces;

    public class Angel : Monster
    {
        private const int AngelHealth = 200;
        private const int AngelAttack = 50;
        private const int AngelDefence = 50;

        public Angel(int id, string name, Position position, bool isAlive)
            : base(id, name, position, AngelHealth, AngelAttack, AngelDefence, isAlive, MonsterType.Holy)
        {
        }

    }
}
