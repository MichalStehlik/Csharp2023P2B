using C08DwarvenPoker;

const int PLAYERS = 2;
do
{
    Round[] players = new Round[2];
    for (int i = 0; i < PLAYERS; i++)
    {
        players[i] = Game.AddRound(i);
        Console.WriteLine($"Hrac {i + 1}");
        for (int j = 0; j < players[i].Count; j++)
        {
            Console.Write(players[i].Dices[j]);
        }
        Console.WriteLine(" = " + players[i].Score);
        Console.WriteLine("Které kostky zamknout?");
        string mask = Console.ReadLine() ?? "     ";
        for (int j = 0; j < Math.Min(mask.Length, players[i].Count); j++)
        {
            //if (mask[j] != ' ') players[i].SetLock(j, !(players[i].GetLock(j)));
            if (mask[j] != ' ') players[i].Dices[j].Lock = !players[i].Dices[j].Lock;
        }
        Console.WriteLine();
        players[i].Roll();
        for (int j = 0; j < players[i].Count; j++)
        {
            Console.Write(players[i].GetDice(j));
        }
        Console.WriteLine(" = " + players[i].Score);
    }
    int result = Game.ResolveRound(players[0], players[1]);
    switch (result)
    {
        case 1: Console.WriteLine("1 vyhrál"); break;
        case 2: Console.WriteLine("2 vyhrál"); break;
        default: Console.WriteLine("?"); break;
    }
    Console.Write("[quit?]:");
    string? command = Console.ReadLine();
    if (command!.StartsWith("q")) break;
}
while (true);
Console.WriteLine("1 = " + Game.Player1Wins);
Console.WriteLine("2 = " + Game.Player2Wins);