
namespace IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AtbashArrays atbashArrays = new AtbashArrays();
            bool toExit = false;
            while (!toExit)
            {
                MenuManager.ShowMenu();
                string choice = MenuManager.GetChoice();
                bool validated = MenuManager.Validate(choice);
                if (!validated)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else if (choice == "3")
                {
                    toExit = true;
                    continue;
                }
                else
                {
                    MenuManager.ActivateChoice(choice, atbashArrays);
                }
            }
            
        }
    }
}
