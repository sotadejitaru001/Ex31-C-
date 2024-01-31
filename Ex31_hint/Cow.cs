using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    internal class Cow:Animal
    {
        //public int bullet = 0;
        public Cow(string name, float hp, float power) : base(name, hp, power) { }
        public override void Attack(Character destination)
        {
            if ( hp> 5)
            {
                Console.WriteLine($"{this.name}は{destination.name}に角で突く！");
                Console.WriteLine($"{destination.name}はうしろに吹っ飛んだ！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            }
            else
            {
                Console.WriteLine($"{base.name}は体力切れです！");
            }
        }
    }
}
