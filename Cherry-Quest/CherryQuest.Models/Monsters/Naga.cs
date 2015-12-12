namespace TW.Monsters
{
    using Enums;

    public class Naga : Monster
    {
        private const int NagaHealth = 120;
        private const int NagaAttack = 40;
        private const int NagaDefence = 30;

        public Naga(int id, string name, Position position, bool isAlive)
            : base(id, name, position, NagaHealth, NagaAttack, NagaDefence, isAlive, MonsterType.Warrior)
        {
        }
    }
}
