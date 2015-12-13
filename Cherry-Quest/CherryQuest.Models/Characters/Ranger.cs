namespace CherryQuest.Models.Characters
{
    using Microsoft.Xna.Framework.Graphics;

    public class Ranger : Character
    {
        public Ranger(int attack, int defence, CharacterLevel level, int gold, Texture2D texture, int rows, int cols) 
            : base(attack, defence, level, gold, texture, rows, cols)
        {
        }
    }
}
