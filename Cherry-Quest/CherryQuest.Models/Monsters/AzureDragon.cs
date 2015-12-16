namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework.Graphics;

    public class AzureDragon : Monster
    {
        private const int AzureHealth = 250;
        private const int AzureAttack = 60;
        private const int AzureDefence = 40;

        //TODO Content
        public AzureDragon(Texture2D texture, int rows, int cols)
            : base(AzureHealth, AzureAttack, AzureDefence, rows, cols)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }
    }
}
