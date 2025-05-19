using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateExercises
{
    internal class ShopingCart
    {
        private double _TotalCost = 0;
        private List<string> _Items = new List<string>();
        public double GetTotalCost()
        {
            return this._TotalCost;
        }
        public void AddItem(string item, double cost)
        {
            this._Items.Add(item);
            this._TotalCost += cost;
        }
        public void RemoveItem(string item, double cost)
        {
            if (this._Items.Contains(item))
            {
                this._Items.Remove(item);
                this._TotalCost -= cost;
            }
            else
            {
                Console.WriteLine("No such item");
            }
            
        }
        public void ShowCart()
        {
            Console.WriteLine("Items:");
            foreach (string item in this._Items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(
                $"Total Cost:\n" +
                $"${this._TotalCost}");
        }
    }
}
