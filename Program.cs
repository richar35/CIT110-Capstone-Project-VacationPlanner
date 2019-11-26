using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VacationPlanner
{
    class Program
    {
        public enum BudgetItems
        {
            CAR,
            FUEL,
            PLANE,
            BAG,
            FOOD,
            ALCOHOL,
            EXCURSIONS,
            SOUVENIERS,
            HOTEL,
            DONE,
            NONE


        }
        static void Main(string[] args)
        {
            List<BudgetItems> budgetItems = new List<BudgetItems>();




            DisplayWelcomeScreen();
            DisplayMainMenu();


        }

        /// <summary>
        /// display welcome screen
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tIts time to plan your vacation!");
            Console.WriteLine();

            DisplayContinuePrompt();

            Console.WriteLine("This application will help you plan your travel budget. Weather you have a destination picked or need some suggestions based on your budget.");


            DisplayContinuePrompt();

        }

        static void DisplayMainMenu()
        {

            bool quitApplication = false;
            string menuChoice;

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            do
            {
                DisplayScreenHeader("Main Menu");

                //
                // get the user's menu choice
                //

                Console.WriteLine("a) About the Vacation Planner");
                Console.WriteLine("b) List of Budget Items");
                Console.WriteLine("c) Add a Budget Item");
                Console.WriteLine("d) Delete a Budget Item");
                Console.WriteLine("e) Update a Budget Item");
                Console.WriteLine("f) Have a destination in mind? Plan your Vacation Budget here");
                Console.WriteLine("g) No destination in mind? Choose this option.");
                Console.WriteLine("q) Quit");
                Console.WriteLine(" Enter Choice: ");

                menuChoice = Console.ReadLine().ToLower();

                //
                // process user's choice
                //
                switch (menuChoice)
                {
                    case "a":
                        DisplayAboutApplication();
                        break;

                    case "b":

                        break;

                    case "c":
                        //Display add item
                        break;

                    case "d":
                        DisplayDeleteItem();
                        break;

                    case "e":
                        DisplayUpdatItem();
                        break;

                    case "f":
                        DisplayPlanBudget();
                        break;
                    case "g":
                        DisplayUnPlannedMenu();
                        break;

                    case "q":
                        quitApplication = true;
                        break;


                }

            } while (!quitApplication);

            DisplayContinuePrompt();
        }

        private static void DisplayUpdatItem()
        {

        }

        private static void DisplayDeleteItem()
        {

        }


        private static void DisplayViewItems()
        {

        }

        static void DisplayUnPlannedMenu()
        {
            bool quitApplication = false;
            string menuChoice;
            int budget = 0;
            

            do
            {
                DisplayScreenHeader("Where can you go?");

                //
                // get the user's menu choice
                //
                Console.WriteLine("a) Enter your budget");
                Console.WriteLine("b) Where can you go...");
                


                Console.WriteLine(" Enter Choice: ");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user's choice
                //
                switch (menuChoice)
                {
                    case "a":
                        budget = DisplayGetUsersBudget();
                        break;

                    case "b":
                       DisplayUsersBudget(budget);
                        break;






                    default:
                        Console.WriteLine("\t*****************************");
                        Console.WriteLine("\tPlease indicate your choice with a letter.");
                        Console.WriteLine("\t*****************************");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }

        //
        //Get the users budget
        //
        static int DisplayGetUsersBudget()
        {
            string userResponse;
            int budget;
           

            DisplayScreenHeader("Choose your next destination by providing a your Budget.");

            Console.WriteLine();
            Console.WriteLine("Please enter a total amount that you would like to spend on your vacation: ");
            userResponse = Console.ReadLine();
            budget = int.Parse(userResponse);

            Console.WriteLine($"Your budget is {budget}.");

            DisplayContinuePrompt();

            return budget;

            
  

        }

        static void DisplayUsersBudget(int budget)
        {
           

            if (budget > 0 && budget < 100)
            {
                Console.WriteLine("You should consider the following places for your next Vacation:");
                DisplayContinuePrompt();
            }
            else if (budget >100 && budget < 500)
            {
                Console.WriteLine("You should consider the following places for your next Vacation:");
            }
            else if (budget > 500 && budget < 1000)
            {
                Console.WriteLine("You should consider the following places for your next Vacation:");
            }
            else if (budget > 1000 && budget < 1500)
            {
                Console.WriteLine("You should consider the following places for your next Vacation:");
            }
            else if (budget > 1500 && budget < 2000)
            {
                Console.WriteLine("You should consider the following places for your next Vacation:");
            }
            else if (budget > 2000 && budget < 3000)
            {
                Console.WriteLine("You should consider the following places for your next Vacation:");
            }
            else if (budget > 3000 && budget < 5000)
            {
                Console.WriteLine("You should consider the following places for your next Vacation:");
            }
            else if (budget > 5000)
            {
                Console.WriteLine("You should consider the following places for your next Vacation:");
            }
            else
            {
                Console.WriteLine("Please enter a budget between $100 and $10,000");
            }

            DisplayContinuePrompt();
        }


      

       

        private static void DisplayUnplannedBudget()
        {
            DisplayScreenHeader("Lets plan your next vacation.");

            Console.WriteLine();
            Console.WriteLine("Below is a list of items that can be budgeted for your ");
            DisplayContinuePrompt();
        }

        private static void DisplayPlanBudget()
        {
            DisplayScreenHeader("About the Vacation Planner");

            Console.WriteLine("Already know your destination budget list");
            DisplayContinuePrompt();
        }

        private static void DisplayAboutApplication()
        {
            DisplayScreenHeader("About the Vacation Planner");

            Console.WriteLine("About the application");
            DisplayContinuePrompt();
        }

        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

     

        static void DisplayWriteBudgetItemData(List<BudgetItems> items)
        {
            string dataPath = @"Data\Data.txt";
            List<string> commandsString = new List<string>();


            DisplayScreenHeader("Save Commands to the Data File");

            Console.WriteLine("Ready to save the commands to the data file");
            DisplayContinuePrompt();

            foreach (BudgetItems item in items)
            {
                commandsString.Add(item.ToString());
            }

            File.WriteAllLines(dataPath, commandsString.ToArray());

            Console.WriteLine();
            Console.WriteLine("Commands successfully saved.");


            DisplayContinuePrompt();
        }






        #region Prompts

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display main menu prompt
        /// </summary>
        static void DisplayMainMenuPrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
            //DisplayMainMenu();
        }

        #endregion

        static void DisplayGetBudgetItems(List<BudgetItems> items)
        {

            BudgetItems item = BudgetItems.NONE;
            string userResponse;


            DisplayScreenHeader("Budget Items to Consider for your trip");

            Console.WriteLine(" Choose from the 9 items below. When finished type DONE. ");

            Console.WriteLine("a) Car Rental ");
            Console.WriteLine("b) Fuel");
            Console.WriteLine("c) Plane Ticket");
            Console.WriteLine("d) Baggage Fee");
            Console.WriteLine("e) Food");
            Console.WriteLine("f) Beverages");
            Console.WriteLine("g) Excursions");
            Console.WriteLine("h) Souveniers");
            Console.WriteLine("i) Hotel");

            DisplayContinuePrompt();

            while (item != BudgetItems.DONE)
            {
                Console.Write("Enter Command:");
                userResponse = Console.ReadLine().ToLower();

                switch (item)
                {
                    case 
                        BudgetItems.CAR:
                        break;

                    case
                        BudgetItems.FUEL:
                        break;

                    case BudgetItems.PLANE:
                        break;

                    case BudgetItems.BAG:
                        break;

                    case BudgetItems.FOOD:
                        break;

                    case BudgetItems.ALCOHOL:
                        break;

                    case BudgetItems.EXCURSIONS:
                        break;

                    case BudgetItems.SOUVENIERS:
                        break;

                    case BudgetItems.HOTEL:
                        break;

                    case BudgetItems.DONE:
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please enter a valid Budget Item.");
                        Console.WriteLine();
                        break;
                }

                Enum.TryParse(userResponse, out item);



                if (item != BudgetItems.NONE)
                {
                    items.Add(item);
                }

            }
            Console.WriteLine($"Budget Items have been entered to the list.");

            DisplayContinuePrompt();

            DisplayBudgetItems(items);

            Console.WriteLine("*****************************************************");

            DisplayContinuePrompt();
        }

        //
        //List of items the user chooses
        //
        static void DisplayBudgetItems(List<BudgetItems> items)
        {
            DisplayScreenHeader("Your Budget Items");

            foreach (BudgetItems item in items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Press any key to continue to the budget planner.");

            DisplayContinuePrompt();
        }



    }

    }

