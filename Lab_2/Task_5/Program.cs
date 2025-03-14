using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Створюємо героя
            IBuilder heroBuilder = new HeroBuilder();
            CharacterDirector director = new CharacterDirector(heroBuilder);
            var hero = director.BuildHero();

            Console.WriteLine($"Герой: Зріст: {hero.Height}, Добрі справи: {string.Join(", ", hero.GoodDeeds)}");

            // Створюємо ворога
            IBuilder enemyBuilder = new EnemyBuilder();
            var enemy = new CharacterDirector(enemyBuilder).BuildEnemy();

            Console.WriteLine($"Ворог: Зріст: {enemy.Height}, Злі справи: {string.Join(", ", enemy.EvilDeeds)}");
        }
    }
}
