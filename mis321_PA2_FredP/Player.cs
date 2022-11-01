using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis321_PA2_FredP
{
    public class Player
    {
        public IAttack attack;
        public string UserName {get; set;}
        public string characterName {get; set;}

        public double Hitpoints {get; set;}

        public int MaxPower{get; set;}
        public int AttackStrength {get; set;}
        public int DefensePower {get; set;}
        public string Character {get; set;}
        public double AttackDamage {get; set;}
        
    }

    public Player()
    {

    }

    public string GetUserName()
    {
        System.Console.WriteLine("Enter your Username: ");
        UserName = console.ReadLine();
        return UserName; 
    }

    public int GetMaxPower()
    {
        Random random = new Random();
        int MaxPower = random.Next(1,100);
        System.Console.WriteLine($"This character's Max Power is: {MaxPower}");
        return MaxPower;
    }

    public int GetAttackStrength(int MaxPower)
    {
        Random random = new Random();
        int AttackStrength = random.Next(1,MaxPower);
        System.Console.WriteLine($"Your Max Attack Strength is {AttackStrength}");
        return AttackStrength;
    }

    public int GetDefensePower(int MaxPower)
    {
        Random random = new Random();
        int DefensePower = random.Next(1,MaxPower);
        System.Console.WriteLine($"Your Max Defense Strength is {DefensePower}");
        return DefensePower;






        
    }

    public void PlayerOneStats(Player playerOne, Player playerTwo)
    {
        System.Console.WriteLine($"{playerOne.UserName} is attacking {playerTwo.UserName}");
        System.Console.WriteLine($"Update: User1: {playerOne.UserName} \n Player Name : {playerOne.CharacterName} \nHitpoints: {playerOne.Hitpoints} \nAttack Strength: {playerOne.AttackStrength} \nDefense Strength: {playerOne.DefenseStrength}");
        System.Console.WriteLine($"Update: User2: {playerTwo.UserName} \n Player Name : {playerTwo.CharacterName} \nHitpoints: {playerTwo.Hitpoints} \nAttack Strength: {playerTwo.AttackStrength} \nDefense Strength: {playerTwo.DefenseStrength}");
    }
        public void PlayerTwoStats(Player playerOne, Player playerTwo)
    {
        System.Console.WriteLine($"{playerTwo.UserName} is attacking {playerOne.UserName}");
        System.Console.WriteLine($"Update: User2: {playerTwo.UserName} \n Player Name : {playerTwo.CharacterName} \nHitpoints: {playerTwo.Hitpoints} \nAttack Strength: {playerTwo.AttackStrength} \nDefense Strength: {playerTwo.DefenseStrength}");
        System.Console.WriteLine($"Update: User1: {playerOne.UserName} \n Player Name : {playerOne.CharacterName} \nHitpoints: {playerOne.Hitpoints} \nAttack Strength: {playerOne.AttackStrength} \nDefense Strength: {playerOne.DefenseStrength}");
    }
}