﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hardware_store
{
    public class Position
    {
        public AbstractGoods Goods;// ссылка на товар
        public int Quantity { get; set; }// кол-во товара
        public Position(AbstractGoods goods, int quantity) 
        {
            Goods=goods;
            Quantity = quantity;

        }
        public double GetPositionPrice() //возвращает цену 1 позиции
        {
            return Goods.GetPrice(Quantity) ;
        }
    }
    public class Order
    {
        public string NameCustomers { get; set; }
        public string DateOfCreation { get; set; }
        public List<Position>Positions { get; set;}// позиции заказа

        public Order(string nameCustomers,string dateOfCreation)
        {
            NameCustomers = nameCustomers;
            DateOfCreation = dateOfCreation;
            Positions = new List<Position>();
        }
        public void AddPosition(Position position)//  добавление позиции в заказ
        {
            Positions.Add(position);
        }
        public double TotalPrice()
        {
            double totalPrice = 0;
            foreach (Position position in Positions)
            {
                totalPrice += position.GetPositionPrice();
            }
            return totalPrice;
        }
    }
}
