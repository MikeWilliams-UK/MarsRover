namespace MarsRover
{
    internal class Program
    {
        private static MarsRover? _rover;

        private static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                var direction = Direction.North;
                switch (args[2].ToUpper())
                {
                    case "N":
                        direction = Direction.North;
                        break;
                }
                _rover = new MarsRover(int.Parse(args[0]), int.Parse(args[1]), direction);

                while (true)
                {
                    Console.WriteLine("Enter Command(s):");

                    var commands = Console.ReadLine()?.ToUpper();

                    if (!string.IsNullOrEmpty(commands))
                    {
                        _rover.ExecuteCommands(commands);
                        if (commands.Contains("X"))
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Command Line arguments PositionX PositionY Direction - i.e. 1 1 n");
            }
        }
    }
}