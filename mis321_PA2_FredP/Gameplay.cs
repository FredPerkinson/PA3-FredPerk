using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis321_PA2_FredP
{
    public class Gameplay : Player
    {
        public void PlayerOneMove(Player playerOne, Player playerTwo)
        {
            if(playerOne.characterName == "Davy Jones" && playerTwo.characterName == "Jack Sparrow" || playerOne.characterName == "Jack Sparrow" && playerTwo.characterName == "Will Turner" || playerOne.characterName == "Will Turner" && playerTwo.characterName = "Davy Jones") //Gets matchup boost
            {
                System.Console.WriteLine(playerOne.characterName + " has a 20% boost against " + playerTwo.characterName);
                if(playerOne.AttackStrength > playerTwo.DefensePower) 
                {
                    playerOne.AttackDamage = (playerOne.AttackStrength - playerTwo.DefensePower) * 1.2; //Attack gets matchup boost
                    Math.Round(playerOne.AttackDamage, 0, MidpointRounding.AwayFromZero); 
                    playerTwo.Hitpoints = playerTwo.Hitpoints - playerOne.AttackDamage; //Hitpoints taken away
                    playerOne.PlayerOneStats(playerOne, playerTwo); 
                }
                else
                {
                    playerOne.AttackDamage = 1;
                    playerTwo.Hitpoints = playerTwo.Hitpoints - playerOne.AttackDamage;
                    playerOne.PlayerOneStats(playerOne, playerTwo); 
                }
            }
            else
            {
                if(playerOne.AttackStrength > playerTwo.DefensePower)
                {
                    playerOne.AttackDamage = (playerOne.AttackStrength - playerTwo.DefensePower);
                    Math.Round(playerOne.AttackDamage, 0, MidpointRounding.AwayFromZero);  
                    playerTwo.Hitpoints = playerTwo.Hitpoints - playerOne.AttackDamage;
                    playerOne.PlayerOneStats(playerOne, playerTwo); 
                }
                else
                {
                    playerOne.AttackDamage = 1;
                    Math.Round(playerOne.AttackDamage, 0, MidpointRounding.AwayFromZero); 
                    playerTwo.Hitpoints = playerTwo.Hitpoints - playerOne.AttackDamage;
                    playerOne.PlayerOneStats(playerOne, playerTwo); 
                }
            }
        }
        public void PlayerTwoMove(Player playerTwo, Player playerOne)
        {
            playerTwo.attackBehavior.Attacking();
            if(playerTwo.CharacterName == "Jack Sparrow" && playerOne.CharacterName == "Will Turner" || playerTwo.CharacterName == "Will Turner" && playerOne.CharacterName == "Davy Jones" || playerTwo.CharacterName == "Davy Jones" && playerOne.CharacterName == "Jack Sparrow")
            {
                 if(playerOne.AttackStrength > playerTwo.DefensePower) 
                {
                    playerOne.AttackDamage = (playerOne.AttackStrength - playerTwo.DefensePower) * 1.2; 
                    Math.Round(playerOne.AttackDamage, 0, MidpointRounding.AwayFromZero); 
                    playerTwo.Hitpoints = playerTwo.Hitpoints - playerOne.AttackDamage;
                    playerOne.PlayerTwoStats(playerOne, playerTwo); 
                }
                else
                {
                    playerOne.AttackDamage = 1;
                    playerTwo.Hitpoints = playerTwo.Hitpoints - playerOne.AttackDamage;
                    playerOne.PlayerTwoStats(playerOne, playerTwo); 
                }
            }
            else
            {
                if(playerOne.AttackStrength > playerTwo.DefensePower)
                {
                    playerOne.AttackDamage = (playerOne.AttackStrength - playerTwo.DefensePower);
                    Math.Round(playerOne.AttackDamage, 0, MidpointRounding.AwayFromZero);  
                    playerTwo.Hitpoints = playerTwo.Hitpoints - playerOne.AttackDamage;
                    playerOne.PlayerTwoStats(playerOne, playerTwo); 
                }
                else
                {
                    playerOne.AttackDamage = 1;
                    Math.Round(playerOne.AttackDamage, 0, MidpointRounding.AwayFromZero); 
                    playerTwo.Hitpoints = playerTwo.Hitpoints - playerOne.AttackDamage;
                    playerOne.PlayerTwoStats(playerOne, playerTwo); 
                }
            }
        }
    }
}