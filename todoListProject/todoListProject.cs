using System;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList todoList = new TodoList();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Ajouter une tâche");
                Console.WriteLine("2. Afficher les tâches");
                Console.WriteLine("3. Supprimer une tâche");
                Console.WriteLine("4. Quitter");
                Console.Write("Choisissez une option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Entrez la description de la tâche: ");
                        string description = Console.ReadLine();
                        todoList.AddTask(description);
                        break;
                    case "2":
                        todoList.DisplayTasks();
                        break;
                    case "3":
                        Console.Write("Entrez l'ID de la tâche à supprimer: ");
                        int id;
                        if (int.TryParse(Console.ReadLine(), out id))
                        {
                            todoList.RemoveTask(id);
                        }
                        else
                        {
                            Console.WriteLine("ID invalide.");
                        }
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Option invalide.");
                        break;
                }
            }
        }
    }

    class TodoList
    {
        private List<TodoTask> tasks = new List<TodoTask>();
        private int nextId = 1;

        public void AddTask(string description)
        {
            TodoTask newTask = new TodoTask(nextId, description);
            tasks.Add(newTask);
            nextId++;
            Console.WriteLine("Tâche ajoutée avec succès.");
        }

        public void DisplayTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Aucune tâche à afficher.");
            }
            else
            {
                foreach (TodoTask task in tasks)
                {
                    Console.WriteLine($"ID: {task.Id}, Description: {task.Description}");
                }
            }
        }

        public void RemoveTask(int id)
        {
            TodoTask taskToRemove = tasks.Find(task => task.Id == id);
            if (taskToRemove != null)
            {
                tasks.Remove(taskToRemove);
                Console.WriteLine("Tâche supprimée avec succès.");
            }
            else
            {
                Console.WriteLine("Tâche non trouvée.");
            }
        }
    }

    class TodoTask
    {
        public int Id { get; }
        public string Description { get; }

        public TodoTask(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}