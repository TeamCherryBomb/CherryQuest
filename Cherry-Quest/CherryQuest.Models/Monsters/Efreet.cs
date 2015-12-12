namespace TW.Monsters
{
    using Enums;

    public class Efreet : Monster
    {
        private const int EfreetHealth = 80;
        private const int EfreetAttack = 45;
        private const int EfreetDefence = 25;

        public Efreet(int id, string name, Position position, bool isAlive)
            : base(id, name, position, EfreetHealth, EfreetAttack, EfreetDefence, isAlive, MonsterType.Caster)
        {
        }
    }
}
