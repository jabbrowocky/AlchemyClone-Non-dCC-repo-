using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyClone
{
    class Game
    {
        Dictionary <int , Element> unlockableElements = new Dictionary<int, Element>();
        Player user;
        bool gameRunning = true;
        
        
        public Game()
        {
            
        }
        public void RunGame()
        {
            Element firstSelection;
            Element secondSelection;
            Element potentialResult;
            CreateUnlockableDictionary();
            CreatePlayer();

            while (gameRunning)
            {
                DisplayElements();
                firstSelection = ElementCreator(GetElementFirstSelection());
                secondSelection = ElementCreator(GetElementSecondSelection());
                if (firstSelection != null && secondSelection != null)
                {
                    potentialResult = ElementCombiner(firstSelection, secondSelection);
                    if (potentialResult == null)
                    {
                        Console.WriteLine("Please try again. Press any key to continue");
                        Console.ReadKey(true);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("You've created {0}! Press any key to continue", potentialResult.ElementName);
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("Please try again. Press any key to continue");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                if (unlockableElements.Count == 0)
                {
                    Console.WriteLine("You've unlocked all elements! press any key to end game.");
                    Console.ReadKey(true);
                    gameRunning = false;
                }
                
            }
        }
        private void CreateUnlockableDictionary()
        {
            Steam steam = new Steam();
            Pressure pressure = new Pressure();
            unlockableElements.Add(steam.ElementNumber, steam);
            unlockableElements.Add(pressure.ElementNumber, pressure);
        }
        private void CreatePlayer()
        {
            user = new Player();    
        }
        private void DisplayElements()
        {
            Console.WriteLine("{0} currently has the following elements available", user.PlayerName);
            foreach(KeyValuePair<int, Element> element in user.unlockedElements)
            {
                Console.WriteLine("\nElement Number: {0}\nElement Name: {1}", element.Key, element.Value.ElementName);
            }
        }
        private string GetElementFirstSelection()
        {
            string firstSelection;           
            Console.WriteLine("Select the first of your avaialable elements.");
            firstSelection = Console.ReadLine();
            return firstSelection;
        }
        private string GetElementSecondSelection()
        {
            string secondSelection;
            Console.WriteLine("Select the second of your avaialable elements.");
            secondSelection = Console.ReadLine();
            return secondSelection;
        }

        private Element ElementCreator(string element)
        {
            element = element.ToLower();
            Element elementToCreate;
            foreach (KeyValuePair<int, Element> unlockedElement in user.unlockedElements)
            {
                if(unlockedElement.Value.ElementName.ToLower() == element)
                {
                    elementToCreate = unlockedElement.Value;
                    return elementToCreate;
                }
            }
            return null;
        }
        private Element ElementCombiner(Element firstElement, Element secondElement)
        {
            Element newElement;
            StringBuilder ingredientA = new StringBuilder();
            
            StringBuilder ingredientB = new StringBuilder();
            
            foreach (KeyValuePair<int, Element> element in unlockableElements)
            {
                ingredientA.Append(element.Value.recipeOne[0].ElementName);
                
                ingredientB.Append(element.Value.recipeOne[1].ElementName);
                
                
                if ((ingredientA.ToString() == firstElement.ElementName) && (ingredientB.ToString() == secondElement.ElementName))
                {
                    newElement = element.Value;
                    unlockableElements.Remove(element.Value.ElementNumber);
                    user.unlockedElements.Add(element.Value.ElementNumber, element.Value);
                    return newElement;
                }
                else if ((ingredientA.ToString() == secondElement.ElementName)&&(ingredientB.ToString() == firstElement.ElementName))
                {
                    newElement = element.Value;
                    unlockableElements.Remove(element.Value.ElementNumber);
                    user.unlockedElements.Add(element.Value.ElementNumber, element.Value);
                    return newElement;
                }
            }
            
            return null;
        }
        
    }
}
