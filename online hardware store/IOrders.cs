using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hardware_store
{
    public interface IOrder
    {
        public void AddPosition(Position position);
        public double TotalPrice();
    }
}
    
