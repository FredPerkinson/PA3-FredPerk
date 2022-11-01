using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pa2
{
    public class Gameplay : Player
    {
        public void PlayerOneMove(Player playerOne, Player playerTwo)
        {   
            playerOne.attack.Attack();
            if(playerOne.CharacterName == "Davy Jones" && playerTwo.CharacterName == "Jack Sparrow" || playerOne.CharacterName == "Jack Sparrow" && playerTwo.CharacterName == "Will Turner" || playerOne.CharacterName == "Will Turner" && playerTwo.CharacterName == "Davy Jones") //Gets matchup boost
            {
                System.Console.WriteLine(playerOne.CharacterName + " has a 20% boost against " + playerTwo.CharacterName);
                if(playerOne.AttackStrength > playerTwo.DefensePower) 
                {
                    playerOne.AttackDamage = (playerOne.AttackStrength - playerTwo.DefensePower) * 1.2; //Attack gets matchup boost
                    Math.Round(playerOne.AttackDamage, 0, MidpointRounding.AwayFromZero); 
                    playerTwo.Hitpoints = playerTwo.Hitpoints - playerOne.AttackDamage; //Hitpoints taken away
                    Player.PlayerTwoStats(playerOne, playerTwo); 
                }
                else
                {
                    playerOne.AttackDamage = 1;
                    playerTwo.Hitpoints = playerTwo.Hitpoints - playerOne.AttackDamage;
                    Player.PlayerTwoStats(playerOne, playerTwo); 
                }
            }
            else
            {
                if(playerOne.AttackStrength > playerTwo.DefensePower)
                {
                    playerOne.AttackDamage = (playerOne.AttackStrength - playerTwo.DefensePower);
                    Math.Round(playerOne.AttackDamage, 0, MidpointRounding.AwayFromZero);  
                    playerTwo.Hitpoints = playerTwo.Hitpoints - playerOne.AttackDamage;
                    Player.PlayerTwoStats(playerOne, playerTwo); 
                }
                else
                {
                    playerOne.AttackDamage = 1;
                    Math.Round(playerOne.AttackDamage, 0, MidpointRounding.AwayFromZero); 
                    playerTwo.Hitpoints = playerTwo.Hitpoints - playerOne.AttackDamage;
                    Player.PlayerTwoStats(playerOne, playerTwo); 
                }
            }
        }
        public void PlayerTwoMove(Player playerTwo, Player playerOne)
        {
            playerTwo.attack.Attack();
            if(playerTwo.CharacterName == "Jack Sparrow" && playerOne.CharacterName == "Will Turner" || playerTwo.CharacterName == "Will Turner" && playerOne.CharacterName == "Davy Jones" || playerTwo.CharacterName == "Davy Jones" && playerOne.CharacterName == "Jack Sparrow")
            {
                 if(playerOne.AttackStrength > playerTwo.DefensePower) 
                {
                    playerTwo.AttackDamage = (playerTwo.AttackStrength - playerOne.DefensePower) * 1.2; 
                    Math.Round(playerOne.AttackDamage, 0, MidpointRounding.AwayFromZero); 
                    playerOne.Hitpoints = playerOne.Hitpoints - playerTwo.AttackDamage;
                    Player.PlayerOneStats(playerOne, playerTwo); 
                }
                else
                {
                    playerTwo.AttackDamage = 1;
                    playerOne.Hitpoints = playerOne.Hitpoints - playerTwo.AttackDamage;
                    Player.PlayerOneStats(playerOne, playerTwo); 
                }
            }
            else
            {
                if(playerOne.AttackStrength > playerTwo.DefensePower)
                {
                    playerTwo.AttackDamage = (playerTwo.AttackStrength - playerOne.DefensePower);
                    Math.Round(playerOne.AttackDamage, 0, MidpointRounding.AwayFromZero);  
                    playerOne.Hitpoints = playerOne.Hitpoints - playerTwo.AttackDamage;
                    Player.PlayerOneStats(playerOne, playerTwo); 
                }
                else
                {
                    playerTwo.AttackDamage = 1;
                    Math.Round(playerOne.AttackDamage, 0, MidpointRounding.AwayFromZero); 
                    playerOne.Hitpoints = playerOne.Hitpoints - playerTwo.AttackDamage;
                    Player.PlayerOneStats(playerOne, playerTwo); 
                }
            }
        }
    }
}