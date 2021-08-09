using System;
using System.Collections.Generic;

namespace lab5._1RPGclasses
{
    class Character
    {
        public string name;
        public int strength;
        public int intelligence;
        public virtual void Play()
        {
            Console.WriteLine("Hi");
        }
    }
    class warrior : Character
    {
        public string weapontype;
        public override void Play()
        {
            Console.WriteLine($"{name} (int: {intelligence}, str: {strength}) {weapontype}");
        }
    }
    class MagicusingCharacters : Character
    {
        public int magicalEnergy;
    }

    class wizard : MagicusingCharacters
    {
        public int spellnumber;
        public override void Play()
        {
            Console.WriteLine($"{name} (int: {intelligence}, str: {strength}, Magic: {magicalEnergy}) {spellnumber} spells");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the World of Dev.BuildCraft!");
            warrior w1 = new warrior();
            w1.name = "Thorak the Barbarian";
            w1.intelligence = 5;
            w1.strength = 17;
            w1.weapontype = "Axe";

            warrior w2 = new warrior() { strength = 16, intelligence = 6, name = "Gorknar The Warrior", weapontype = "Mace" };
            warrior w3 = new warrior() { strength = 19, intelligence = 3, name = "Ragnar the impaler", weapontype = "Spear" };

            wizard wiz1 = new wizard();
            wiz1.name = "Pearl The Magician";
            wiz1.intelligence = 18;
            wiz1.strength = 4;
            wiz1.magicalEnergy = 10;
            wiz1.spellnumber = 5;
            wizard wiz2 = new wizard() { strength = 3, intelligence = 19, magicalEnergy = 12, spellnumber = 6, name = "Alakazam The Magnificient", };

            List<Character> gameCharacters = new List<Character>();
            gameCharacters.Add(w1);
            gameCharacters.Add(w2);
            gameCharacters.Add(wiz1);
            gameCharacters.Add(w3);
            gameCharacters.Add(wiz2);

            foreach(Character newguy in gameCharacters)
            {
                newguy.Play();
            }


       
        }
    }
}
