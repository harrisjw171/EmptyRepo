using System;

namespace OOPExercises.Classes
{
    class Musician
    {
        public string Name { get; set; }
        public Guitar Guitar { get; set; }

        public Musician(string name, Guitar guitar)
        {
            Name = name;
            Guitar = guitar;
        }
        public void Play()
        {
            Console.WriteLine($"{Name} plays the {Guitar.Brand}, {Guitar.Price}");
        }
    }
}
