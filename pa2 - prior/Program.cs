using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pa2
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
            System.Console.WriteLine($"\nPlayer: {playerOne.UserName}\nCharacter: {playerOne.CharacterName}\nMaxPower: {playerOne.MaxPower}\nHitpoints: {playerOne.Hitpoints}\nAttackStrength: {playerOne.AttackStrength}\nDefensivePower: {playerOne.DefensePower}");
            System.Console.WriteLine($"\nPlayer: {playerTwo.UserName}\nCharacter: {playerTwo.CharacterName}\nMaxPower: {playerTwo.MaxPower}\nHitpoints: {playerTwo.Hitpoints}\nAttackStrength: {playerTwo.AttackStrength}\nDefensivePower: {playerTwo.DefensePower}");
            Action(playerOne, playerTwo);
        }
        public static Player GetUserCharacter()
        {
            Player player = new Player();
            Menu menu = new Menu();
            int userInput = menu.GetCharacter();
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
            player = new JackSparrow(){UserName = player.GetUserName(),CharacterName = "Jack Sparrow",Hitpoints = 100, MaxPower = maxPower, AttackStrength = player.GetAttackStrength(maxPower),DefensePower = player.GetDefensePower(maxPower)};
            return player;
        }

        public static Player WillTurner(Player player)
        {
            Menu menu = new Menu();
            System.Console.WriteLine("You choose Will Turner with a special sword attack");
            System.Console.WriteLine("You begin the game with 100 hitpoints");
            int maxPower = player.GetMaxPower();
            player = new WillTurner(){UserName = player.GetUserName(), CharacterName = "Will Turner", Hitpoints = 100, MaxPower = maxPower, AttackStrength = player.GetAttackStrength(maxPower), DefensePower = player.GetDefensePower(maxPower)};
            return player;
        }

        public static Player DavyJones(Player player)
        {
            Menu menu = new Menu();
            System.Console.WriteLine("You choose Davy Jones with a special cannon attack");
            System.Console.WriteLine("You begin the game with 100 hitpoints");
            int maxPower = player.GetMaxPower();
            player = new DavyJones(){UserName = player.GetUserName(),CharacterName = "Davy Jones",Hitpoints = 100, MaxPower = maxPower, AttackStrength = player.GetAttackStrength(maxPower),DefensePower = player.GetDefensePower(maxPower)};
            return player;
        }
        public static Player ElizabethSwann(Player player)
        {
            Menu menu = new Menu();
            System.Console.WriteLine("You choose Elizabeth Swann");
            System.Console.WriteLine("You begin the game with 100 hitpoints");
            int maxPower = player.GetMaxPower();
            player = new ElizabethSwann(){UserName = player.GetUserName(),CharacterName = "Elizabeth Swann", Hitpoints = 100, MaxPower = maxPower, AttackStrength = player.GetAttackStrength(maxPower),DefensePower = player.GetDefensePower(maxPower)};
            return player;
        }

        public static void Action(Player playerOne, Player playerTwo)
        {
            Gameplay gameplay = new Gameplay();
            Random random = new Random();
            Player.PlayerOneStats(playerOne, playerTwo);
            Player.PlayerTwoStats(playerOne, playerTwo);
            string value = "Nothing";                       
            int randomNumber = random.Next(1,3);         //Makes numbers for coin toss
            if(randomNumber == 1)            //Makes Heads or Tails 
            {
                value = "heads";               
            }
            else
            {
                value = "tails";
            }
            System.Console.WriteLine("Player one. Choose heads or tails to decide who will begin the game.");
            string userInput = Console.ReadLine();
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

            while(playerOne.Hitpoints > 0 && playerTwo.Hitpoints > 0)       //Checks to see if players have no Hitpoints remaining
            {
                if(userInput == value)
                {
                    gameplay.PlayerOneMove(playerOne, playerTwo);
                    if(playerTwo.Hitpoints > 0)
                    {
                        gameplay.PlayerTwoMove(playerTwo, playerOne);
                    }
                }
                else
                {
                    gameplay.PlayerTwoMove(playerTwo, playerOne);
                    if(playerOne.Hitpoints > 0)
                    {
                        gameplay.PlayerOneMove(playerOne, playerTwo);
                    }
                }
            }

            if(playerOne.Hitpoints > playerTwo.Hitpoints)                   //Declares winner
            {
                System.Console.WriteLine("Player One has won the game!");
                System.Console.WriteLine("Exiting game...");
                System.Console.WriteLine("Thank you for playing!");
            }
            else
            {
                System.Console.WriteLine("Player Two has won the game!");
                System.Console.WriteLine("Exiting game...");
                System.Console.WriteLine("Thank you for playing!");
            }

            static void Exit()      //Exits game
            {
                Environment.Exit(0);
            }
        }
    }
}