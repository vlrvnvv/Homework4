using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class Manager : IAlive
    {
        public int Health { get ; set ; }

        public void FeedAnimal(Animal animal)
        {
            animal.Health += 10;

            //Для теста отработки события
            Console.WriteLine($"Менеджер покормил животное"); 
        }
    }
}
