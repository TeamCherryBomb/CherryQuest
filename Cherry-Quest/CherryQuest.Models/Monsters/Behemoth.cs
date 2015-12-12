namespace TW.Monsters
{
    using Enums;

    public class Behemoth : Monster
    {
        private const int BehemothHealth = 160;
        private const int BehemothAttack = 40;
        private const int BehemothDefence = 30;

        public Behemoth(int id, string name, Position position, bool isAlive)
            : base(id, name, position, BehemothHealth, BehemothAttack, BehemothDefence, isAlive, MonsterType.Beast)
        {

        }
    }
}
