namespace TW.Monsters
{
    using Enums;

    public class BlackDragon : Monster
    {
        private const int BlackHealth = 180;
        private const int BlackAttack = 50;
        private const int BlackDefence = 50;

        public BlackDragon(int id, string name, Position position, bool isAlive)
            : base(id, name, position, BlackHealth, BlackAttack, BlackDefence, isAlive, MonsterType.Dragon)
        {
        }
    }
}
