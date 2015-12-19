namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Naga : Monster
    {
        private const int NagaHealth = 120;
        private const int NagaAttack = 40;
        private const int NagaDefence = 30;

        //TODO Content
        public Naga(int rows, int cols, ContentManager content)
            : base(NagaHealth, NagaAttack, NagaDefence, rows, cols, content)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }
    }
}
