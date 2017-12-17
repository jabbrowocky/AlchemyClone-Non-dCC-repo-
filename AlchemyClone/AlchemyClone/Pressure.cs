using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyClone
{
    class Pressure : Element
    {
        
        public Pressure()
        {
            CreateRecipeOne();
            ElementName = "Pressure";
            ElementNumber = 6;
        }
        public void CreateRecipeOne()
        {
            recipeOne = new Element[] { new Earth(), new Earth() };
        }
    }
}
