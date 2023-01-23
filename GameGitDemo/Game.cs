namespace GameGitDemo;

internal class Game
{

    public void Run()
    {
        WriteLine("=== Welcome to the Game ===");

        Write("What is your name? ");
        string name = ReadLine();
   
        Player currentPlayer = new(name);

        WriteLine($"Let's get started, {currentPlayer.Name}!");

        WriteLine("\nPress any key to exit...");
        ReadKey(true);
    }
}
