using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Game<TLevel> 
    {
        public List<TLevel> Levels { get; set; } 

        public Game(List<TLevel> levels) /// передаем список уровней
        {
            Levels = levels;
        }

        public void DisplayLevels() 
        {
            foreach (var level in Levels)
            {
                Console.WriteLine($"Level: {level}"); /// выводим в консоль информацию об уровнях
            }
        }

    }
}
