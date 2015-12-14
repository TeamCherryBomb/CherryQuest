namespace CherryQuest.Models.Characters
{
    using Microsoft.Xna.Framework.Graphics;

    public class Ranger : Character
    {
        private const int RangerAttack = 8;
        private const int RangerDefense = 4;

        public Ranger(Texture2D texture, int rows, int cols)
            : base(RangerAttack, RangerDefense, texture, rows, cols)
        {
        }
    }
}
