namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Elf : Monster
    {
        private const int ElfHealth = 50;
        private const int ElfAttack = 30;
        private const int ElfDefence = 10;

        //TODO Content
        public Elf(int rows, int cols, ContentManager content)
            : base(ElfHealth, ElfAttack, ElfDefence, rows, cols, content)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }
    }
}
