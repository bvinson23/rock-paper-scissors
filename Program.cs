using System;

void PlayerHand(int pick)
{
    if (pick == 1)
    {
        Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
        ");
    }
    if (pick == 2)
    {
        Console.WriteLine(@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
        ");
    }
    if (pick == 3)
    {
        Console.WriteLine(@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
        ");
    }
}

int playerScore = 0;
int computerScore = 0;
Play();

void Play()
{
    Console.Clear();
    if (playerScore == 3)
    {
        Console.WriteLine("You win!!");
    }
    else if (computerScore == 3)
    {
        Console.WriteLine("You lost to a computer, bow before you're new overlords.");
    }
    else
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"| Player: {playerScore}  |  Computer: {computerScore} |");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("What would you like to throw?");
        Console.WriteLine("1) Rock");
        Console.WriteLine("2) Paper");
        Console.WriteLine("3) Scissors");

        string pick = Console.ReadLine();
        int playerPick = int.Parse(pick);

        Random i = new Random();
        int computerPick = i.Next(1, 3);
        PlayerHand(playerPick);
        Console.WriteLine("VS");
        PlayerHand(computerPick);
        System.Threading.Thread.Sleep(750);

        if (playerPick == computerPick)
        {
            Play();
        }
        else if (playerPick == 1)
        {
            if (computerPick == 2)
            {
                computerScore++;
                Play();
            }
            else
            {
                playerScore++;
                Play();
            }
        }
        else if (playerPick == 2)
        {
            if (computerPick == 3)
            {
                computerScore++;
                Play();
            }
            else
            {
                playerScore++;
                Play();
            }
        }
        else if (playerPick == 3)
        {
            if (computerPick == 1)
            {
                computerScore++;
                Play();
            }
            else
            {
                playerScore++;
                Play();
            }
        }
    }
}