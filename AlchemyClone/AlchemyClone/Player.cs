using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyClone
{
    class Player
    {
        public Dictionary<int, Element> unlockedElements;
        string playerName;
        public string PlayerName
        {
            get
            {
                return playerName;
            }
            set
            {
                playerName = value;
            }
        }

        public Player()
        {
            GetPlayerName();
            AddInitialElements(unlockedElements = new Dictionary<int, Element>());
        }
        private void GetPlayerName()
        {
            Console.WriteLine("Name yoself foo!");
            PlayerName = Console.ReadLine();
        }
        private void AddInitialElements(Dictionary<int,Element> unlockedElements)
        {
            
            Air air = new Air();
            Earth earth = new Earth();
            Water water = new Water();
            Fire fire = new Fire();
            unlockedElements.Add(air.ElementNumber, air);
            unlockedElements.Add(fire.ElementNumber, fire);
            unlockedElements.Add(water.ElementNumber, water);
            unlockedElements.Add(earth.ElementNumber, earth);
           
        }
        
    }
}
