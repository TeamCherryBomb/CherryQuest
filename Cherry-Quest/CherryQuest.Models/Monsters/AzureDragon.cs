namespace CherryQuest.Models.Monsters
{
    using Microsoft.Xna.Framework.Graphics;

    public class AzureDragon : Monster
    {
        private const int AzureHealth = 250;
        private const int AzureAttack = 60;
        private const int AzureDefence = 40;

        public AzureDragon(Texture2D texture, int rows, int cols)
            : base(AzureHealth, AzureAttack, AzureDefence, texture, rows, cols)
        {
        }
    }
}
