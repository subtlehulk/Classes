using System;

namespace Classes
{
    public class Wizard
    {
        //CLASS VARIABLES
        public string wizardName {get; set;}
        public int age {get; set;}
        float magicalAbility {get; set;}

        bool beenToHogwarts {get; set;}

        //CLASS CONSTRUCTORS
        public Wizard ()
        {
            wizardName = "Harry Potter";
            age = 11;
            magicalAbility = 9.99f;
            beenToHogwarts = true;
        }

        //CLASS METHODS
        public void CreateWizard()
        {
            Console.WriteLine("Hello, young wizard! What is your name?");
            wizardName = Console.ReadLine();
            Console.WriteLine("Ah, I see. And now, how old are you, hmm?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Interesting, interesting. Well, let's see now. That would put your magical ability at about..");
            if (age < 16)
            {
                magicalAbility = 1.25f;
            } 
            else
            {
                magicalAbility = 5.5f;
            } 
            Console.WriteLine($"a {magicalAbility} out of 10.00! Not bad for someone your age.");
        }

        public void Print()
        {
            Console.WriteLine("name: " + wizardName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Magical ability out of 10: " + magicalAbility);
        }
    }

}