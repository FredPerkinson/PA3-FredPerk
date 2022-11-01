using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis321_PA2_FredP
{
    public class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Welcome to the Game!");
            Menu menu = new Menu();
            Player playerOne = new Player(); //Creates playerOne
            Player playerTwo = new Player(); //Creats playerTwo
            playerOne = GetUserCharacter();
            playerTwo = GetUserCharacter();
            System.Console.WriteLine($"\nPlayer: {playerOne.UserName}\nCharacter: {playerOne.CharacterName}\nMaxPower: {playerOne.MaxPower}\nHealth: {playerOne.Health}\nAttackStrength: {playerOne.AttackStrength}\nDefensivePower: {playerOne.DefensePower}");
            System.Console.WriteLine($"\nPlayer: {playerTwo.UserName}\nCharacter: {playerTwo.CharacterName}\nMaxPower: {playerTwo.MaxPower}\nHealth: {playerTwo.Health}\nAttackStrength: {playerTwo.AttackStrength}\nDefensivePower: {playerTwo.DefensePower}");
            Gameplay(playerOne, playerTwo, damage);
        }
        public static Player GetUserCharacter()
        {
            Player player = new Player();
            int userInput = player.GetPlayer();
            switch(userInput)
            {
                case 1: player = JackSparrow(player);
                    break;
                case 2: player = WillTurner(player);
                    break; 
                case 3: player = DavyJones(player);
                    break;
                case 4: player = ElizabethSwann(player);
                    break;
                default:
                System.Console.WriteLine("Error. Please choose from the listed options");
                player.GetPlayer();
                break;
            }
            return player;
        }

        public static Player JackSparrow(Player player)
        {
            Menu menu = new Menu();
            System.Console.WriteLine("You choose Jack Sparrow with a special distract attack");
            System.Console.WriteLine("You begin the game with 100 hitpoints");
            int maxPower = player.GetMaxPower();
            player = new JackSparrow(){UserName = myCharacter.GetUserName(),CharacterName = "Jack Sparrow",Health = 100, MaxPower = maxPower, AttackStrength = myCharacter.GetAttackStrength(maxPower),DefensePower = myCharacter.GetDefensePower(maxPower)};
            return player;
        }

        public static Player WillTurner(Player player)
        {
            Menu menu = new Menu();
            System.Console.WriteLine("You choose Will Turner with a special sword attack");
            System.Console.WriteLine("You begin the game with 100 hitpoints");
            int maxPower = player.GetMaxPower();
            player = new WillTurner(){UserName = myCharacter.GetUserName(), CharacterName = "Will Turner", Health = 100, MaxPower = maxPower, AttackStrength = myCharacter.GetAttackStrength(maxPower), DefensePower = myCharacter.GetDefensePower(maxPower)};
            return player;
        }

        public static Player DavyJones(Player player)
        {
            Menu menu = new Menu();
            System.Console.WriteLine("You choose Davy Jones with a special cannon attack");
            System.Console.WriteLine("You begin the game with 100 hitpoints");
            int maxPower = player.GetMaxPower();
            player = new DavyJones(){UserName = myCharacter.GetUserName(),CharacterName = "Davy Jones",Health = 100, MaxPower = maxPower, AttackStrength = myCharacter.GetAttackStrength(maxPower),DefensePower = myCharacter.GetDefensePower(maxPower)};
            return player;
        }
        public static Player ElizabethSwann(Player player)
        {
            Menu menu = new Menu();
            System.Console.WriteLine("You choose Elizabeth Swann");
            System.Console.WriteLine("You begin the game with 100 hitpoints");
            int maxPower = player.GetMaxPower();
            player = new ElizabethSwann(){UserName = myCharacter.GetUserName(),CharacterName = "Elizabeth Swann", Health = 100, MaxPower = maxPower, AttackStrength = myCharacter.GetAttackStrength(maxPower),DefensePower = myCharacter.GetDefensePower(maxPower)};
            return player;
        }

        public static void Action(Player playerOne, Player playerTwo, double hitpointDamage)
        {
            Gameplay gameplay = new Gameplay();
            Random random = new Random();
            string value = "Nothing";                       
            int randomNumber = newRandom.Next(1,3);         //Makes numbers for coin toss
            if(randomNumber = 1)            //Makes Heads or Tails 
            {
                value = "heads";               
            }
            else(randomNumber = 2);
            {
                value = "tails";
            }
            System.Console.WriteLine("Player one. Choose heads or tails to decide who will begin the game.");
            int userInput = Console.ReadLine();
            while(userInput != "heads" && userInput != "tails")     //Error handling
            {
                System.Console.WriteLine("Error...");
                System.Console.WriteLine("Player one. Choose heads or tails to decide who will begin the game.");
                userInput = Console.ReadLine();
            }

            if(userInput == value)      //Decides who goes first
            {
                System.Console.WriteLine("Player one you won the coin toss and go first!");
            }
            else{
                System.Console.WriteLine("Player two you won the coin toss and go first!");
            }

            while(playerOne.Hitpoints > 0 && playerTwo.Hitpoints > 0)       //Checks to see if players have no health remaining
            {
                if(userInput == randomNumber)
                {
                    newGameplay.PlayerOneTurn(playerOne, playerTwo);
                    if(playerTwo.Hitpoints > 0)
                    {
                        newGameplay.PlayerTwoTurn(playerTwo, playerOne);
                    }
                }
                else
                {
                    newGameplay.PlayerTwoTurn(playerTwo, playerOne);
                    if(playerOne.Hitpoints > 0)
                    {
                        newGameplay.PlayerOneTurn(playerOne, playerTwo);
                    }
                }
            }

            if(playerOne.Hitpoints > playerTwo.Hitpoints)                   //Declares winner
            {
                System.Console.WriteLine("Player One has won the game!");
            }
            else
            {
                System.Console.WriteLine("Player Two has won the game!");
            }

            // static void Exit()      //Exits game
            // {
            //     System.Console.WriteLine("Exiting game...");
            //     System.Console.WriteLine("Thank you for playing!");
            //     Environment.Exit(0);
            // }
        }
    }
}