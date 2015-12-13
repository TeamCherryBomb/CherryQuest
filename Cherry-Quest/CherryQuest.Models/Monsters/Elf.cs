namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework.Graphics;

    public class Elf : Monster
    {
        private const int ElfHealth = 50;
        private const int ElfAttack = 30;
        private const int ElfDefence = 10;

        public Elf(Texture2D texture, int rows, int cols)
            : base(ElfHealth, ElfAttack, ElfDefence, texture, rows, cols)
        {
        }
    }
}
