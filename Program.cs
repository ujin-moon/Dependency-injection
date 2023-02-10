using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ISound
    {
        void dosomethink(string message);
    }
    public class Sound : ISound
    {
        public void dosomethink(string message)
        {
            Console.WriteLine($"Собака сказала: {message}");
        }
    }
    public class Dog
    {
        private readonly ISound _sound;

        public Dog(ISound sound)
        {
            _sound = sound;
        }
        public void dosomethink(string message)
        {
            _sound.dosomethink(message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog(new Sound());
            dog.dosomethink("ГАВ-ГАВ");
            Console.ReadLine();
        }
    }
}
