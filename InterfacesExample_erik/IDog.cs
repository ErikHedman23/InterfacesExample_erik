using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample_erik
{
   public interface IDog
    {
        public string Breed { get; set; }
        public void BurySomething();
    }
}
