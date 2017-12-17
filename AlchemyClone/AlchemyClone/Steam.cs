using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyClone
{
    class Steam : Element

    {
        
        
        public Steam()
        {
            CreateRecipeOne();
            ElementName = "Steam";
            ElementNumber = 5;
        }
        public void CreateRecipeOne()
        {
            recipeOne = new Element[] { new Fire(), new Water()};
        }
    }
}
