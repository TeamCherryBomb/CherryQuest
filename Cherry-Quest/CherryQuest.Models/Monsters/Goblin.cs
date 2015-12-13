namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework.Graphics;

    public class Goblin : Monster
    {
        private const int GoblinHealth = 30;
        private const int GoblinAttack = 10;
        private const int GoblinDefence = 7;

        public Goblin(Texture2D texture, int rows, int cols)
            : base(GoblinHealth, GoblinAttack, GoblinDefence, texture, rows, cols)
        {
        }
    }
}