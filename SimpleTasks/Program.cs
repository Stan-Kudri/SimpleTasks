using System;

namespace SimpleTasks
{
    

    class Program
    {
        static void ChoosinAndPerformingTask(ISimpleTask[] simpleTasks)
        {
            Console.Write("\nВведите номер задачи:");
            string str = Console.ReadLine();
            int number;

            if( (!int.TryParse(str, out number)) || (int.Parse(str) <= 0) || (int.Parse(str) > 15) )
            {
                Console.WriteLine("Такого задания нет, вы захотели выйт -_-");
                return;
            }
            else
            {
                simpleTasks[int.Parse(str)-1].Execute();
            }
            ChoosinAndPerformingTask(simpleTasks);
        }

        static void Main(string[] args)
        {
            var array = new ISimpleTask[15] 
            { new Task1(), new Task2(), new Task3(),
              new Task4(), new Task5(), new Task6(),
              new Task7(), new Task8(), new Task9(),
              new Task10(), new Task11(), new Task12(),
              new Task13(), new Task14(), new Task15()
            };
            
            Console.WriteLine("Вывод условий задач, которые можно выполнить:");
            for(int i = 0; i < 15; i++)
            {
                Console.WriteLine($"{i + 1}) {array[i].Name}");
            }
            Console.WriteLine("-Любые другие символы завершают программу!");
            ChoosinAndPerformingTask(array);

            Console.ReadLine();
        }
    }
}
