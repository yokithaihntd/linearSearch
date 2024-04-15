using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical7
{
    class TaskManager
    {
        private List<Task> tasks;

        public TaskManager()
        {
            tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public List<Task> FindTasksByStatus(string status)
        {
            List<Task> foundTasks = new List<Task>();

            foreach (var task in tasks)
            {
                if (task.Status == status)
                {
                    foundTasks.Add(task);
                }
            }

            return foundTasks;
        }
    }
}
