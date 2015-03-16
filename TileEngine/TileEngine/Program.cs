using System;

namespace TileEngine
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            //call tile editor
            using (Game1 game = new Game1())
            {
                game.Run();
            }
        }
    }
#endif
}

