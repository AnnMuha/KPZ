using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Virus : IPrototype
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public List<Virus> Offspring { get; set; }

        // Конструктор
        public Virus(string name, int weight, int age, string species)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Species = species;
            Offspring = new List<Virus>();
        }

        // Метод для глибокого клонування
        public IPrototype DeepClone()
        {
            Virus clone = (Virus)this.MemberwiseClone();
            clone.Offspring = new List<Virus>();

            foreach (var child in this.Offspring)
            {
                clone.Offspring.Add((Virus)child.DeepClone());
            }

            return clone;
        }

        // Додаємо дочірній вірус
        public void AddChild(Virus child)
        {
            Offspring.Add(child);
        }

        // Виведення інформації про вірус та його "нащадків"
        public void DisplayInfo(string indent = "")
        {
            Console.WriteLine($"{indent}Вірус: {Name}, Вид: {Species}, Вага: {Weight}, Вік: {Age}");
            foreach (var child in Offspring)
            {
                child.DisplayInfo(indent + "  ");
            }
        }
    }
}
