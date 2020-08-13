﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    class Program
    {
        class Cat
        {
            public Cat()
            {
                Name = "";
                Color = "";
            }
            public Cat(string _Name, string _Color)
            {
                Name = _Name;
                Color = _Color;
            }
            ~Cat()
            {
                Console.WriteLine($"{Name} : 잘가");
            }
                
            public string Name;
            public string Color;

            public void Meow()
            {
                Console.WriteLine($"{Name} : 야옹");
            }
        }
        static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.Color = "하얀색";
            kitty.Name = "키티";
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat();
            nero.Color = "검은색";
            nero.Name = "네로";
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}
