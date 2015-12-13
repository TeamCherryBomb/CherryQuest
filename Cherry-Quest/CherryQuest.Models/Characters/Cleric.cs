namespace CherryQuest.Models.Characters
{
    using Microsoft.Xna.Framework.Graphics;

    public class Cleric : Character
    {
        public Cleric(int attack, int defence, CharacterLevel level, int gold, Texture2D texture, int rows, int cols) 
            : base(attack, defence, level, gold, texture, rows, cols)
        {
        }
    }
}
