// Lee Houk
// IT113
// NOTES: This was a good project to get usedto traversing the list in different aspects.
// BEHAVIORS NOT IMPLIMENTED AND WHY: NONE
namespace Houk_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a new linked list
            LinkedList MyLinkedList = new LinkedList();

            //Greeting
            Console.WriteLine("Welcome to My Sorted Linked List Program!");
            //Begin the menu loop until the user exits
            bool exit = false;
            while (exit == false)
            {
                // Variables to store user input
                string userInput = "";
                string choice;

                //Generate a menu                
                Console.WriteLine("Please select an option from the menu below:");
                Console.WriteLine("1. Add an item to the list");
                Console.WriteLine("2. Remove an item from the list");
                Console.WriteLine("3. Check if an item is in the list");
                Console.WriteLine("4. Print all items in the list");
                Console.WriteLine("5. Exit the program");

                //Get user input
                choice = Console.ReadLine();

                //Process user input using case switch
                switch (choice)
                {                   
                    case "1": //Get input and add item to the list
                        Console.WriteLine("Please enter the item you would like to add to the list:");
                        MyLinkedList.Add(choice = Console.ReadLine());
                        Console.WriteLine("\n" + choice + " was successfully added to the list.\n");
                        break;
                    case "2": //Get input and remove and item from the list
                        Console.WriteLine("Please enter the item you would like to remove from the list:");
                        if(MyLinkedList.Remove(choice = Console.ReadLine()) == true)
                        {
                            Console.WriteLine("\n" + choice + " was removed successfully.\n");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n" + choice + " was not found in list.\n");
                            break;
                        }
                    case "3": //Get input and search for an item on the list
                        Console.WriteLine("Please enter the item you would like to search for:");
                        if (MyLinkedList.Contains(choice = Console.ReadLine()) == true)
                        {
                            Console.WriteLine("\n" + choice + " was found in the list.\n");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n" + choice + " was not found in the list\n");
                            break;
                        }
                    case "4": //Print the linked list
                        Console.WriteLine("Printing all items on the list:");
                        MyLinkedList.PrintAllNodes();
                        Console.WriteLine("");
                        break;
                    case "5": //Exit the program
                        exit = true;
                        break;
                }                
            }
        }
    }
}