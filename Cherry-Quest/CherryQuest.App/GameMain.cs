namespace CherryQuest.App
{
    using System;

    public static class GameMain
    {
        [STAThread]
        static void Main()
        {
            using (var game = new CherryGame())
            {
                game.Run();
            }
        }
    }
}
