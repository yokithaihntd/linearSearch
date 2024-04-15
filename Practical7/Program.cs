using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            taskManager.AddTask(new Task("Задача 1", "Открыта"));
            taskManager.AddTask(new Task("Задача 2", "Закрыта"));
            taskManager.AddTask(new Task("Задача 3", "Открыта"));
            taskManager.AddTask(new Task("Задача 4", "В процессе"));
            taskManager.AddTask(new Task("Задача 5", "Закрыта"));
            taskManager.AddTask(new Task("Задача 6", "В процессе"));

            bool exitRequested = false;

            while (!exitRequested)
            {
                Console.WriteLine("Введите статус задачи для поиска:");
                string statusToSearch = Console.ReadLine();

                List<Task> tasksFound = taskManager.FindTasksByStatus(statusToSearch);

                if (tasksFound.Count > 0)
                {
                    Console.WriteLine("Найденные задачи со статусом '" + statusToSearch + "':");
                    foreach (var task in tasksFound)
                    {
                        Console.WriteLine(task.Name);
                    }
                }
                else
                {
                    Console.WriteLine("Задачи со статусом '" + statusToSearch + "' не найдены.");
                }

                Console.WriteLine("Нажмите Enter для продолжения поиска или 'q' для выхода...");
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    exitRequested = true;
                }

                Console.Clear();
            }
        }
    }
}
