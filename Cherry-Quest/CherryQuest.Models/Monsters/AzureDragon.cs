namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class AzureDragon : Monster
    {
        private const int AzureHealth = 250;
        private const int AzureAttack = 60;
        private const int AzureDefence = 40;

        //TODO Content
        public AzureDragon(int rows, int cols, ContentManager content)
            : base(AzureHealth, AzureAttack, AzureDefence, rows, cols, content)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }
    }
}
