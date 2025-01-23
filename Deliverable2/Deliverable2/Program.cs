Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
Console.WriteLine("What is your name?");

string userName = Console.ReadLine();

Console.WriteLine($"Welcome {userName}. Do you want to do the COIN FLIP CHALLENGE? Yes/No");

string startGame  = Console.ReadLine();

if (startGame.ToUpper() == "NO")
{
    Console.WriteLine($"You are a coward {userName}");
    return;
} else if (startGame.ToUpper() == "YES")
{
    Console.WriteLine("How many rounds do you want to play? 5 or 10?");
    int roundNumber = int.Parse(Console.ReadLine());
    Random coin = new Random();
    int heads = 0;
    int tails = 1;
    int coinFlip;
    string userGuess;
    string statusMessage = "";
    int totalScore = 0;
    for (int i = 1; i <= roundNumber; i++)
    {
        Console.WriteLine("Heads or Tails?");
        userGuess = Console.ReadLine();
        coinFlip = coin.Next(0,2);
        if ((userGuess.ToLower() == "heads") && (heads == coinFlip))
        {
            statusMessage = "Correct!";
            totalScore++;
        } else if ((userGuess.ToLower() == "tails") && (tails == coinFlip))
        {
            statusMessage = "Correct!";
            totalScore++;
        } else
        {
            statusMessage = "Wrong!";
        }
        Console.WriteLine(statusMessage);
    }
    Console.WriteLine($"Thank you {userName}. You got a score of {totalScore} out of {roundNumber}!");
}