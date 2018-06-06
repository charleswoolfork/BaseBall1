using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBall1
{
  public class WoodenBat : IBaseBallBat
    {
        public int WeightInGrams { get; set; }

       
        public void Swing()
        {
            Console.WriteLine("Crack"); 
        }
    }
}
