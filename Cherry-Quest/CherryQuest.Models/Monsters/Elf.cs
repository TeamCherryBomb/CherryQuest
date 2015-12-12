namespace CherryQuest.Models.Monsters
{
    using Models;
    using Enums;

    public class Elf : Monster
    {
        private const int ElfHealth = 50;
        private const int ElfAttack = 30;
        private const int ElfDefence = 10;

        public Elf(string name, Position position, bool isAlive)
            : base(name, position, ElfHealth, ElfAttack, ElfDefence, isAlive)
        {
        }
    }
}
