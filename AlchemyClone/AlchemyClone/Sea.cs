using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyClone
{
    class Sea : Element
    {
        public Sea()
        {
            CreateRecipeOne(new Water(), new Water());
            ElementName = "Sea";
            ElementNumber = 8;
        }
    }
}
