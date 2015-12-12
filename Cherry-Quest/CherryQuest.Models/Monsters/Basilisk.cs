namespace TW.Monsters
{
    using Enums;

    public class Basilisk : Monster
    {
        private const int BasiliskHealth = 80;
        private const int BasiliskAttack = 25;
        private const int BasiliskDefence = 25;

        public Basilisk(int id, string name, Position position, bool isAlive)
            : base(id, name, position, BasiliskHealth, BasiliskAttack, BasiliskDefence, isAlive, MonsterType.Beast)
        {

        }
    }
}
