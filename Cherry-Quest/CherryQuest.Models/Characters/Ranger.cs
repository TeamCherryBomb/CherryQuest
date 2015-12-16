namespace CherryQuest.Models.Characters
{
    using Microsoft.Xna.Framework.Graphics;

    public class Ranger : Character
    {
        private const int RangerAttack = 8;
        private const int RangerDefense = 4;

        //TODO Content
        public Ranger(Texture2D texture, int rows, int cols)
            : base(RangerAttack, RangerDefense, rows, cols)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }
    }
}
