using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab3
{
    public class Level
    {
        public ushort LevelNumber { get; set; }

        public Level(ushort levelNumber)
        {
            LevelNumber = levelNumber;
            if (levelNumber <= 0) /// проверка на правильность записи уровня
            {
                throw new ArgumentException("LevelNumber must be greater than 0");
            }
            else
            {
                this.LevelNumber = levelNumber;
            }
        }

        public override string ToString() /// позволяет записать уровни как: Level 1 и так далее
        {
            return $"Level {LevelNumber}";
        }
    }
}