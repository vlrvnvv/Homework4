using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public abstract class Animal : IAlive
    {
        private int _health; 
        public int Health 
        { 
            get 
            {
                return _health; 
            }
            set 
            {
                _health = value;

                if (_health < 0)
                {
                    Notify?.Invoke(this);
                }
            }
        }

        public delegate void HungerHandler(Animal animal);
        public event HungerHandler? Notify; 
    }
}
