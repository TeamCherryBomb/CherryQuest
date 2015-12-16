namespace CherryQuest.App.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Models.Exceptions;
    using Models.Interfaces;

    public static class CharacterFactory
    {
        private const string RequiredAssemblyName = "CherryQuest.Models";

        public static ICharacter Create(string characterClassName, ContentManager content, int x, int y)
        {
            var currentAssembly = Assembly.Load(RequiredAssemblyName);
            var currentType = currentAssembly.GetTypes().FirstOrDefault(t => t.Name == characterClassName);

            if (currentType == null)
            {
                throw new UnknownCharacterClassException();
            }

            return (ICharacter)Activator.CreateInstance(currentType, content, x, y);
        }
    }
}
