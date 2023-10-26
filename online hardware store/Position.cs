using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static online_hardware_store.Position;

namespace online_hardware_store
{
        public class Position
        {
            public IGoods Goods;// ссылка на товар
            public int Quantity { get; set; }// кол-во товара
            public Position(IGoods goods, int quantity)
            {
                Goods = goods;
                Quantity = quantity;
             }
        
            public double GetPositionPrice() //возвращает цену 1 позиции
            {
                return Goods.GetPrice(Quantity);
            }
        }
 }

