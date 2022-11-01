using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pa2
{
    public class Player
    {
        public IAttack attack;
        public string UserName {get; set;}
        public string CharacterName {get; set;}

        public double Hitpoints {get; set;}

        public int MaxPower{get; set;}
        public int AttackStrength {get; set;}
        public int DefensePower {get; set;}
        public string Character {get; set;}
        public double AttackDamage {get; set;}
        
    

    public Player()
    {

    }

    public string GetUserName()
    {
        System.Console.WriteLine("Enter your Username: ");
        UserName = Console.ReadLine();
        return UserName; 
    }

    public int GetMaxPower()
    {
        Random random = new Random();
        MaxPower = random.Next(1,100);
        System.Console.WriteLine($"This character's Max Power is: {MaxPower}");
        return MaxPower;
    }

    public int GetAttackStrength(int MaxPower)
    {
        Random random = new Random();
        AttackStrength = random.Next(1,MaxPower);
        System.Console.WriteLine($"Your Max Attack Strength is {AttackStrength}");
        return AttackStrength;
    }

    public int GetDefensePower(int MaxPower)
    {
        Random random = new Random();
        DefensePower = random.Next(1,MaxPower);
        System.Console.WriteLine($"Your Max Defense Strength is {DefensePower}");
        return DefensePower;






        
    }

    public static void PlayerOneStats(Player playerOne, Player playerTwo)
    {
        System.Console.WriteLine($"{playerOne.UserName} is attacking {playerTwo.UserName}");
        System.Console.WriteLine($"Update: User1: {playerOne.UserName} \n Player Name : {playerOne.CharacterName} \nHitpoints: {playerOne.Hitpoints} \nAttack Strength: {playerOne.AttackStrength} \nDefense Strength: {playerOne.DefensePower}");
        System.Console.WriteLine($"Update: User2: {playerTwo.UserName} \n Player Name : {playerTwo.CharacterName} \nHitpoints: {playerTwo.Hitpoints} \nAttack Strength: {playerTwo.AttackStrength} \nDefense Strength: {playerTwo.DefensePower}");
    }
    public static void PlayerTwoStats(Player playerOne, Player playerTwo)
    {
        System.Console.WriteLine($"{playerTwo.UserName} is attacking {playerOne.UserName}");
        System.Console.WriteLine($"Update: User2: {playerTwo.UserName} \n Player Name : {playerTwo.CharacterName} \nHitpoints: {playerTwo.Hitpoints} \nAttack Strength: {playerTwo.AttackStrength} \nDefense Strength: {playerTwo.DefensePower}");
        System.Console.WriteLine($"Update: User1: {playerOne.UserName} \n Player Name : {playerOne.CharacterName} \nHitpoints: {playerOne.Hitpoints} \nAttack Strength: {playerOne.AttackStrength} \nDefense Strength: {playerOne.DefensePower}");
    }

    }
}