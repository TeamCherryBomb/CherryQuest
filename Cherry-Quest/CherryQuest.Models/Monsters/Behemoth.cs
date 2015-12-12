namespace CherryQuest.Models.Monsters
{
    using Models;
    using Enums;

    public class Behemoth : Monster
    {
        private const int BehemothHealth = 160;
        private const int BehemothAttack = 40;
        private const int BehemothDefence = 30;

        public Behemoth(string name, Position position, bool isAlive)
            : base(name, position, BehemothHealth, BehemothAttack, BehemothDefence, isAlive)
        {

        }
    }
}
