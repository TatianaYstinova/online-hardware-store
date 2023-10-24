using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hardware_store
{
    public interface IOrder
    {
        public void AddPosition();
        public double TotalPrice();
    }
    public interface ICoods
    {
        public string DoInformation();
        public double GetPrice();

    }
   
   
    
}
