namespace CherryQuest.Models.Characters
{
    using Microsoft.Xna.Framework.Graphics;

    public class Warlock : Character
    {
        private const int WarlockAttack = 9;
        private const int WarlockDefense = 3;

        public Warlock(Texture2D texture, int rows, int cols) 
            : base(WarlockAttack, WarlockDefense, texture, rows, cols)
        {
        }
    }
}
