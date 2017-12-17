using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyClone
{
    class Wind : Element
    {
        
        public Wind()
        {
            CreateRecipeOne(new Air(), new Air());
            ElementName = "Wind";
            ElementNumber = 7;
        }
       
        
    }
    
}
