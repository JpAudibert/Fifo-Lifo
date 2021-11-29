using Fifo_Lifo.Source.Repositories;

TasksRepository taskRepository = new TasksRepository();

bool switchOn = true;

while (switchOn)
{
    Console.WriteLine(@"

    ---- Task List ----
    [1] - Show my next task;
    [2] - Create Task;
    [3] - Create Task List;
    [4] - Switch off
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
            Console.WriteLine("Type the Owner's ID");
            int id = Console.Read();
            break;
        case "2":
            Console.WriteLine(option);
            break;
        case "3":
            Console.WriteLine(option);
            break;
        case "4":
            Console.WriteLine("Switching off");
            switchOn = false;
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }

}
