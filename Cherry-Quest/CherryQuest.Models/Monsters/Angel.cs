namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Angel : Monster
    {
        private const int AngelHealth = 200;
        private const int AngelAttack = 50;
        private const int AngelDefence = 50;

        //TODO Content
        public Angel(int rows, int cols, ContentManager content)
            : base(AngelHealth, AngelAttack, AngelDefence, rows, cols, content)
        {
        }


        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }
    }
}
