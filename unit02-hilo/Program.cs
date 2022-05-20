using game.unit02_hilo;


namespace game.unit02_hilo
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            Player director = new Player();
            director.StartGame();
        }
    }
}