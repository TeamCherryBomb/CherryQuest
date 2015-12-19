namespace CherryQuest.App.Menu
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    public class StartMenu
    {
        private const int ScreenWidth = 1680;
        private const int ScreenHeight = 820;

        private readonly List<MenuElement> main = new List<MenuElement>();
        private readonly List<MenuElement> enterName = new List<MenuElement>();
        private Keys[] lastPresesedKeys = new Keys[5];
        private string name = string.Empty;
        private string classChosen = string.Empty;
        private SpriteFont font;

        public StartMenu()
        {
            main.Add(new MenuElement("pergament"));
            main.Add(new MenuElement("newgame"));
            main.Add(new MenuElement("help"));
            main.Add(new MenuElement("exit"));

            enterName.Add(new MenuElement("pergament"));
            enterName.Add(new MenuElement("enterName"));
            enterName.Add(new MenuElement("start"));
            enterName.Add(new MenuElement("barbarian"));
            enterName.Add(new MenuElement("cleric"));
        }

        public MenuState MenuState{ get; set; }

        public void LoadContent(ContentManager content)
        {
            font = content.Load<SpriteFont>("MyFont");
            foreach (MenuElement element in main)
            {
                element.LoadContent(content);
                element.CenterElement(ScreenWidth, ScreenHeight);
                element.clickEvent += OnClick;
            }
            main.Find(e => e.AssetName == "help").MoveElement(0, 100);
            main.Find(e => e.AssetName == "exit").MoveElement(0, 200);

            foreach (MenuElement element in enterName)
            {
                element.LoadContent(content);
                element.CenterElement(ScreenWidth, ScreenHeight);
                element.clickEvent += OnClick;
            }
            enterName.Find(e => e.AssetName == "start").MoveElement(0, 200);
            enterName.Find(e => e.AssetName == "barbarian").MoveElement(-150, -200);
            enterName.Find(e => e.AssetName == "cleric").MoveElement(0, -200);
        }

        public void Update()
        {
            switch (MenuState)
            {
                case MenuState.MainMenu:
                    foreach (MenuElement element in main)
                    {
                        element.Update();
                    }
                    break;
                case MenuState.EnterName:
                    foreach (MenuElement element in enterName)
                    {
                        element.Update();
                    }
                    GetKeys();
                    break;
                case MenuState.Playing:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            switch (MenuState)
            {
                case MenuState.MainMenu:
                    foreach (MenuElement element in main)
                    {
                        element.Draw(spriteBatch);
                    }
                    break;
                case MenuState.EnterName:
                    foreach (MenuElement element in enterName)
                    {
                        element.Draw(spriteBatch);
                    }
                    spriteBatch.DrawString(font, name, new Vector2(700, 500), Color.Brown);
                    spriteBatch.DrawString(font, classChosen, new Vector2(770, 320), Color.Brown);
                    break;
                case MenuState.Playing:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            spriteBatch.End();
        }

        public void OnClick(string element)
        {
            if (element == "newgame")
            {
                MenuState = MenuState.EnterName;
            }
            if (element == "start")
            {
                MenuState = MenuState.Playing;
            }
            if (element == "barbarian")
            {
                classChosen = "barbarian";
            }
            if (element == "cleric")
            {
                classChosen = "cleric";
            }
        }

        public void GetKeys()
        {
            KeyboardState kbState = Keyboard.GetState();
            Keys[] pressedKeys = kbState.GetPressedKeys();

            //foreach (Keys key in lastPresesedKeys)
            //{
            //    //key is no longer pressed
            //    if (!pressedKeys.Contains(key))
            //    {
            //        OnKeyUp(key);
            //    }
            //}
            foreach (Keys key in pressedKeys)
            {
                if (!lastPresesedKeys.Contains(key))
                {
                    OnKeyDown(key);
                }
            }
            lastPresesedKeys = pressedKeys;
        }

        //public void OnKeyUp(Keys key)
        //{

        //}

        public void OnKeyDown(Keys key)
        {
            if (key == Keys.Back && name.Length > 0)
            {
                name = name.Remove(name.Length - 1);
            }
            else
            {
                name += key.ToString();
            }
        }
    }
}
