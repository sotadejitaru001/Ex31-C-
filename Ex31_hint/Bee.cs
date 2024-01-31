using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Bee:Animal
    {
        public Bee(string name, float hp, float power) : base(name, hp, power) { }
        public override void Attack(Character destination)
        {
            if (destination is Animal)
            {
                Console.WriteLine($"{this.name}は{destination.name}に刺す！");
                Console.WriteLine($"{destination.name}は即死した！");
            }
            else
            {
                Console.WriteLine($"{this.name}は{destination.name}に刺す！");
                Console.WriteLine($"{destination.name}はうしろに吹っ飛んだ！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            }
        }
    }
}
