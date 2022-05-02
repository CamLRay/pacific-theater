using System;
using Ships;
using Players;


class Program
{
  static void Main()
  {
    Console.WriteLine("Player 1: Enter your name.");
    string playerOneName = Console.ReadLine();
    Player player1 = new Player(playerOneName);
    Console.WriteLine(playerOneName + " Choose your ship: Destroyer, Battleship, or Carrier.");
    string playerOneChoice = Console.ReadLine();
    Console.WriteLine(playerOneName + " choose the name of your " + playerOneChoice + ".");
    string playerOneShipName = Console.ReadLine();
    player1.ChooseShip(playerOneChoice, playerOneShipName);

    Console.WriteLine("Player 2: Enter your name.");
    string playerTwoName = Console.ReadLine();
    Player player2 = new Player(playerTwoName);
    Console.WriteLine(playerTwoName + " Choose your ship: Destroyer, Battleship, or Carrier.");
    string playerTwoChoice = Console.ReadLine();
    Console.WriteLine(playerTwoName + " choose the name of your " + playerTwoChoice + ".");
    string playerTwoShipName = Console.ReadLine();
    player2.ChooseShip(playerTwoChoice, playerTwoShipName);
    
    while (player1.Ship.Health > 0 && player2.Ship.Health > 0)
    {
      player1.attack(player2);
      player2.attack(player1);
      Console.WriteLine(player1.PlayerName + " " + player1.Ship.Health);
      Console.WriteLine(player2.PlayerName + " " + player2.Ship.Health);
    }
    if (player1.Ship.Health > 0)
    {
      Console.WriteLine(player2.PlayerName + "(" + player2.Ship.Name + ") Was Sunk");
    }
    else if (player2.Ship.Health > 0)
    {
      Console.WriteLine(player1.PlayerName + "(" + player1.Ship.Name + ") Was Sunk");
    }
  }
}