namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework.Graphics;

    public class Angel : Monster
    {
        private const int AngelHealth = 200;
        private const int AngelAttack = 50;
        private const int AngelDefence = 50;

        public Angel(Texture2D texture, int rows, int cols)
            : base(AngelHealth, AngelAttack, AngelDefence, texture, rows, cols)
        {
        }
    }
}
