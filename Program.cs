Console.WriteLine("Choose what you want to do: ");
Console.WriteLine("Add Task");
Console.WriteLine("Update Task");
Console.WriteLine("Delete Task");
Console.WriteLine("Mark a task as in progress or done");
Console.WriteLine("List all tasks");
Console.WriteLine("List all tasks that are done");
Console.WriteLine("List all tasks that are not done");
Console.WriteLine("List all tasks that are in progress");

int x = Convert.ToInt32(Console.ReadLine());

while(x > 8 || x == 0) 
{
    Console.WriteLine("Please, choose a valid option");
    x = Convert.ToInt32(Console.ReadLine());
}

switch(x) 
{
    case 1: 
        Console.WriteLine("Adding Task");
        break;
    case 2:
        Console.WriteLine("Updating Task");
        break;
    case 3:
        Console.WriteLine("Deleting Task");
        break;
    case 4:
        Console.WriteLine("Marking a task");
        break;
    case 5:
        Console.WriteLine("Listing all tasks");
        break;
    case 6:
        Console.WriteLine("Listing all tasks that are done");
        break;
    case 7:
        Console.WriteLine("Listing all tasks that are not done");
        break;
    case 8:
        Console.WriteLine("Listing all tasks that are in progress");
        break;
}