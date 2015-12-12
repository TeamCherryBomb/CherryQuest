namespace CherryQuest.Models.Monsters
{
    using Models;
    using Enums;

    public class Naga : Monster
    {
        private const int NagaHealth = 120;
        private const int NagaAttack = 40;
        private const int NagaDefence = 30;

        public Naga(string name, Position position, bool isAlive)
            : base(name, position, NagaHealth, NagaAttack, NagaDefence, isAlive)
        {
        }
    }
}
