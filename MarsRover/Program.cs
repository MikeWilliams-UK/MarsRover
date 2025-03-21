namespace MarsRover
{
    internal class Program
    {
        private static MarsRover? _rover;

        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                var direction = MarsRover.Direction.North;
                switch (args[2].ToUpper())
                {
                    case "N":
                        direction = MarsRover.Direction.North;
                        break;
                }
                _rover = new MarsRover(int.Parse(args[0]), int.Parse(args[1]), direction);
            }

            while (true)
            {
                Console.WriteLine("Enter Command:");
                var commands = Console.ReadLine()?.ToUpper();

                _rover.ExecuteCommands(commands);
                if (commands.Contains("X"))
                {
                    break;
                }
            }
        }
    }
}
