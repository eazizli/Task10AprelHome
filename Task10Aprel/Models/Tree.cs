using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task10Aprel.Exceptions;

namespace Task10Aprel.Models
{
    internal class Tree
    {
        public string Name { get; set; }
        public Fruit[] Fruits { get; set; }
        public Fruit this[int index]
        {
            get
            {
                try
                {
                    return Fruits[index];
                }
                catch (IndexOutOfRangeException ex)
                {
                    throw new FruitIndexOutOfRangeException();
                }
            }
            set
            {
                try
                {
                    Fruits[index] = value;
                }
                catch (IndexOutOfRangeException ex)
                {
                    throw new FruitIndexOutOfRangeException();
                }
            }
        }
    }
}