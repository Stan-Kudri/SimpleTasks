using System;

namespace SimpleTasks
{
    class Program
    {
        static bool ChoosinAndPerformingTask(ISimpleTask[] simpleTasks)
        {
            Console.Write("\nВведите номер задачи:");
            string str = Console.ReadLine();
            int number;

            if ((!int.TryParse(str, out number)) || (int.Parse(str) <= 0) || (int.Parse(str) > 15))
            {
                if(str == "exit")
                {
                    Console.WriteLine("вы захотели выйт -_-");
                    return false;
                }
                else
                {
                    Console.WriteLine("Такого задания нет: '{0}'", str);                    
                }
            }
            else
            {
                simpleTasks[int.Parse(str) - 1].Execute();
            }
            return true;
        }

        static void Main(string[] args)
        {
            var array = new ISimpleTask[] 
            {
                new Task1(),
                new Task2(),
                new Task3(),
                new Task4(),
                new Task5(),
                new Task6(),
                new Task7(),
                new Task8(),
                new Task9(),
                new Task10(),
                new Task11(),
                new Task12(),
                new Task13(), 
                new Task14(),
                new Task15()
            };
            
            Console.WriteLine("Вывод условий задач, которые можно выполнить:");

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"{i + 1}) {array[i].Name}");
            
            Console.WriteLine("-Любые другие символы завершают программу!");


            for(bool checkNumberTask = true; checkNumberTask == true;)
            {
                checkNumberTask = ChoosinAndPerformingTask(array);
            }
            

            Console.ReadLine();
        }
    }
}
