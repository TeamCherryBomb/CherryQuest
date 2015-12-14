namespace CherryQuest.Models.Characters
{
    using Microsoft.Xna.Framework.Graphics;

    public class Cleric : Character
    {
        private const int ClericAttack = 4;
        private const int ClericDefense = 8;

        public Cleric(Texture2D texture, int rows, int cols) 
            : base(ClericAttack, ClericDefense, texture, rows, cols)
        {
        }
    }
}
