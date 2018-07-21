using Clocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Console.ReadLine() != "exit")
            {
                Clock clock = new Clock();
                Person person1 = new Person() { Surname = "Incognito1", Name = "Man1", Age = 'M' };
                Person person2 = new Person() { Surname = "Incognito2", Name = "Man2", Age = 'N' };
                Person person3 = new Person() { Surname = "Incognito3", Name = "Man3", Age = 'O' };
                clock.Ring += Clock.ClockRing;
                clock.Ring += person1.Reaction;
                clock.Ring += person2.Reaction;
                clock.Ring += person3.Reaction;

                clock.Set(new TimeSpan(0,0,0,5,0));
            }
        }
    }
}
