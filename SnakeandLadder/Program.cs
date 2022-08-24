namespace SnakeandLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.DieRoll();
            game.Play();
            
        }
    }
}