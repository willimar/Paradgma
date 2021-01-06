using System;

namespace Pradigma
{
    class Program
    {
        static void Wellcome()
        {
            var line = new string('-', 100);
            var space1 = new string(' ', 44);
            Console.Clear();
            Console.WriteLine(line);
            Console.WriteLine($"|{space1} WELLCOME {space1}|");
            Console.WriteLine(line);
        }

        static Solution GetSolution()
        {
            Console.Write("Enter with root name: ");
            var root = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(root))
            {
                throw new ArgumentException("E4: Invalid value to root.");
            }

            return new Solution(root);
        }

        static Solution solution = null;

        static void Main(string[] args)
        {
            while (solution == null)
            {
                Wellcome();

                try
                {
                    solution = GetSolution();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Press the Key to continue.");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("Write exit to finish;");
            var name = string.Empty;

            while (!name.ToLower().Equals("exit"))
            {
                try
                {
                    Console.Write("Value name: ");
                    name = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        throw new ArgumentException("E4: Invalid value to value name");
                    }

                    if (!name.ToLower().Equals("exit"))
                    {
                        Console.Write("Place name: ");
                        var place = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(place))
                        {
                            throw new ArgumentException("E4: Invalid value to place name");
                        }

                        solution.AddItem(name, place);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
