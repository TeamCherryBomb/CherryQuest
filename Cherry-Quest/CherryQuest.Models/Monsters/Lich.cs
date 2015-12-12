namespace TW.Monsters
{
    using Enums;

    public class Lich : Monster
    {
        private const int LichHealth = 70;
        private const int LichAttack = 25;
        private const int LichDefence = 15;

        public Lich(int id, string name, Position position, bool isAlive)
            : base(id, name, position, LichHealth, LichAttack, LichDefence, isAlive, MonsterType.Caster)
        {
        }
    }
}
