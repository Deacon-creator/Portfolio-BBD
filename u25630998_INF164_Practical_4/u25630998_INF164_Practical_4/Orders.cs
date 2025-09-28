using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u25630998_INF164_Practical_4
{
    internal class Orders
    {
        
            // Fields
            private string item;
            private DateTime time;
            private int distance;
            private bool superSize;
            private double price; // calculated inside class

            // Properties (get/set)
            public string Item { get => item; set => item = value; }
            public DateTime Time { get => time; set => time = value; }
            public int Distance
            {
                get => distance;
                set
                {
                    if (value < 1 || value > 60)
                        throw new ArgumentOutOfRangeException("Distance must be between 1 and 60 km.");
                    distance = value;
                }
            }
            public bool SuperSize { get => superSize; set => superSize = value; }
            public double Price { get => price; } // read-only outside class

            // Constructors
            public Orders() { }  // Default constructor

            public Orders(string item, DateTime time, int distance, bool superSize)
            {
                this.Item = item;
                this.Time = time;
                this.Distance = distance;
                this.SuperSize = superSize;
                CalculatePrice();   // automatically calculate price
            }

            // Method to calculate price
            public void CalculatePrice()
            {
                double basePrice = 0;

                switch (Item)
                {
                    case "Sushi": basePrice = 50; break;
                    case "Burger": basePrice = 40; break;
                    case "Pizza": basePrice = 45; break;
                    default: basePrice = 30; break;
                }

                double deliveryCost = Distance * 2;  // R2/km
                double total = basePrice + deliveryCost;

                if (SuperSize)
                    total *= 1.10;   // add 10%

                price = total;
            }

            // ToString (optional for debugging)
            public override string ToString()
            {
                return $"{Item} | {Time.ToLongTimeString()} | {Distance}km | Super: {SuperSize} | R{Price}";
            }


        

    }
}
