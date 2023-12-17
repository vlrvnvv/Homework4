using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public abstract class Predator : Animal
    {
        public List<string> Food { get; set; }
    }
}
