namespace lab3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Level> levels = new List<Level> /// создаем список уровней
        {
            new Level(1),
            new Level(2),
            new Level(3),
            new Level(4),
            new Level(5)
        };
            var Homescapes = new Game<Level>(levels);
            Homescapes.DisplayLevels();
        }
    }
}
