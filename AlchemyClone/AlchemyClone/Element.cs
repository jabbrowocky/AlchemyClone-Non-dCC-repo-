using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyClone
{
    abstract class Element
    {
        string elementName;
        int elementNumber;
        public Element[] recipeOne;
        public Element[] recipeTwo;

        public string ElementName
        {
            get
            {
                return elementName;
            }
            set
            {
                elementName = value;
            }
        }
        public int ElementNumber
        {
            get
            {
                return elementNumber;

            }
            set
            {
                elementNumber = value;
            }
        }
        
    }
}
