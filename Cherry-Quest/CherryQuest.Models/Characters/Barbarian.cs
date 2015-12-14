namespace CherryQuest.Models.Characters
{
    using Microsoft.Xna.Framework.Graphics;

    public class Barbarian : Character
    {
        private const int BarbarianAttack = 10;
        private const int BarbarianDefense = 2;

        public Barbarian(Texture2D texture, int rows, int cols) 
            : base(BarbarianAttack, BarbarianDefense, texture, rows, cols)
        {
        }
    }
}
