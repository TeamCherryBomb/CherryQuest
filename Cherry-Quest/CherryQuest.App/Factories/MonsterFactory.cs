namespace CherryQuest.App.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Microsoft.Xna.Framework.Content;
    using Models.Exceptions;
    using Models.Interfaces;

    public static class MonsterFactory
    {
        private const string RequiredAssemblyName = "CherryQuest.Models";

        public static IMonster Create(string monsterClassName, ContentManager content, int x, int y)
        {
            var currentAssembly = Assembly.Load(RequiredAssemblyName);
            var currentType = currentAssembly.GetTypes().FirstOrDefault(t => t.Name == monsterClassName);

            if (currentType == null)
            {
                throw new UnknownCharacterClassException();
            }

            return (IMonster)Activator.CreateInstance(currentType, content, x, y);
        }
    }
}