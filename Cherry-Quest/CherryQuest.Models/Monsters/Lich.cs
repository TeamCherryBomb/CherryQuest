namespace CherryQuest.Models.Monsters
{
    using Models;
    using Enums;

    public class Lich : Monster
    {
        private const int LichHealth = 70;
        private const int LichAttack = 25;
        private const int LichDefence = 15;

        public Lich(string name, Position position, bool isAlive)
            : base(name, position, LichHealth, LichAttack, LichDefence, isAlive)
        {
        }
    }
}
