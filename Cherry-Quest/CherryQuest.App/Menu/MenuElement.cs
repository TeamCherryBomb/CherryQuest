namespace CherryQuest.App.Menu
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    public class MenuElement
    {
        private string assetName;

        public MenuElement(string assetName)
        {
            this.assetName = assetName;
        }

        public delegate void ElementClicked(string element);

        public event ElementClicked clickEvent;

        public Texture2D ElemTexture { get; set; }

        public Rectangle ElemRect { get; set; }

        public string AssetName
        {
            get { return assetName; }
            set { assetName = value; }
        }

        public void LoadContent(ContentManager content)
        {
            ElemTexture = content.Load<Texture2D>(this.AssetName);
            ElemRect = new Rectangle(0, 0, ElemTexture.Width, ElemTexture.Height);
        }

        public void Update()
        {
            if (ElemRect.Contains(new Point(Mouse.GetState().X, Mouse.GetState().Y)) &&
                Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                clickEvent(this.AssetName);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(ElemTexture, ElemRect, Color.White);
        }

        public void CenterElement(int width, int height)
        {
            ElemRect = new Rectangle((width / 2) - (this.ElemTexture.Width / 2), (height / 2) - (this.ElemTexture.Height / 2), this.ElemTexture.Width, this.ElemTexture.Height);
        }

        public void MoveElement(int x, int y)
        {
            ElemRect = new Rectangle(this.ElemRect.X + x, this.ElemRect.Y + y, this.ElemRect.Width, this.ElemRect.Height);
        }
    }
}
