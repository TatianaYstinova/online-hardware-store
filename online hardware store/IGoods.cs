using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hardware_store
{
    public interface IGoods
    {
        public string DoInformation();
        public double GetPrice(int number);
    }
}
