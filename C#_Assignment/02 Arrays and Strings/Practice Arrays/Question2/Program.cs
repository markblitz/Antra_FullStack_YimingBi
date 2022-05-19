namespace Question2
{
    public class Program
    {
        public static void Main(string[] args){
            List<string> toDoList = new List<string>();
            while (true) 
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                string command = Console.ReadLine();
                if (command == null)
                {
                    Console.WriteLine("Invalid input!\n");
                }
                else if (command == "--")
                {
                    toDoList.Clear();
                    Console.WriteLine("The list is empty!\n");
                }
                else if (command[0] == '+')
                {
                    toDoList.Add(command.Substring(2));
                    PrintList(toDoList);
                }
                else if (command[0] == '-')
                {
                    string toBeDeleted = command.Substring(2);
                    if (toDoList.Contains(toBeDeleted))
                    {
                        toDoList.Remove(toBeDeleted);
                        Console.WriteLine("The element has been deleted!");
                        PrintList(toDoList);
                    }
                    else
                    {
                        Console.WriteLine("Input is not in the list!\n");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!\n");
                }
            }
        }
        public static void PrintList(List<string> list)
        {
            if (list.Count() == 0) { Console.WriteLine("The list is empty!\n"); }
            else
            {
                Console.WriteLine("\nThe list contains: ");
                for (int i = 0; i < list.Count(); i++)
                {
                    Console.WriteLine(list[i]);
                }
                Console.WriteLine("The list ends here!\n");
            }
        }
    }
}