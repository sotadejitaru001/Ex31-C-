using System;


namespace Ex31_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character("しむら人", 500, 2);
            Character character2 = new Character("ささっき", 1000, 25);
            Tank tank1 = new Tank("Tiger", 500000, 250);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク", 10000, 125);
            tank2.bullet = 5;
            Cow cow = new Cow("バイソン", 2000, 50000);
            Cat cat = new Cat("ケトッシー", 300000, 4000);
            Bee bee= new Bee("キラービー", 1000000, 20000);
            Character[] characters = { character1, character2, tank1, tank2,cow,cat,bee };
            Random rand = new Random();
            int r = rand.Next(characters.Length);
            for (var i = 0; i < characters.Length; i++)
            {
                if (characters[i] != characters[r])
                {
                    characters[i].Attack(characters[r]);
                }
                if (characters[r].hp <= 0)
                {
                    Console.WriteLine("__戦闘終了__");
                    break;
                }
            }
        }
    }
}
