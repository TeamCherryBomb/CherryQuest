namespace TW.Monsters
{
    using Enums;

    public class Elf : Monster
    {
        private const int ElfHealth = 50;
        private const int ElfAttack = 30;
        private const int ElfDefence = 10;

        public Elf(int id, string name, Position position, bool isAlive)
            : base(id, name, position, ElfHealth, ElfAttack, ElfDefence, isAlive, MonsterType.Holy)
        {
        }
    }
}
