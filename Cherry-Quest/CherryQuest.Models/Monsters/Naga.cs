namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework.Graphics;

    public class Naga : Monster
    {
        private const int NagaHealth = 120;
        private const int NagaAttack = 40;
        private const int NagaDefence = 30;

        public Naga(Texture2D texture, int rows, int cols)
            : base(NagaHealth, NagaAttack, NagaDefence, texture, rows, cols)
        {
        }
    }
}
