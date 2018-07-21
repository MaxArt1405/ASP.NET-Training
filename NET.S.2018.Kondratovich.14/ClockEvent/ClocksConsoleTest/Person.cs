using Clocks;
using System;

namespace Timer
{
    class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Reaction(object sender, RingEventArgs args)
        {
            Console.WriteLine($"Please, {Surname} {Name}, stop your activity! Timer is over!");
        }
    }
}
