namespace CherryQuest.Models.Characters
{
    using Microsoft.Xna.Framework.Graphics;

    public class Barbarian : Character
    {
        public Barbarian(int attack, int defence, CharacterLevel level, int gold, Texture2D texture, int rows, int cols) 
            : base(attack, defence, level, gold, texture, rows, cols)
        {
        }
    }
}
