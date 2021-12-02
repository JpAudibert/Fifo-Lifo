using Fifo_Lifo.Source.Repositories;

TasksRepository taskRepository = new TasksRepository();

bool switchOn = true;

while (switchOn)
{
    Console.WriteLine(@"
    ---- Task List ----
    [1] - Show my next task;
    [2] - Create Task;
    [3] - Switch off
    ");

    string option = null;

    while (option == null)
    {
        Console.WriteLine("Please, insert a not null value");
        option = Console.ReadLine();
    }

    switch (option)
    {
        case "1":
            Console.WriteLine(taskRepository.ReturnNextTask());
            taskRepository.RemoveTask();
            break;
        case "2":
            Console.WriteLine("Type the owner's name:");
            string owner = Console.ReadLine();
            Console.WriteLine("Type the task:");
            string task = Console.ReadLine();
            taskRepository.InsertTask(owner, task);
            break;
        case "3":
            Console.WriteLine("Switching off");
            switchOn = false;
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }

}
