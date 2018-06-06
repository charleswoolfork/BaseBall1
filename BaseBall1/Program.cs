using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBall1
{
    public class Program
    {
        private static BaseBallPlayer chuck;

        public static WoodenBat WoodenBat { get; private set; }
        public static AluminumBat AluminumBat { get; private set; }

        private static object CompositeBat;

        static void Main(string[] args)
        {
            chuck = new BaseBallPlayer();
            WoodenBat = new WoodenBat();
            AluminumBat = new AluminumBat();
            CompositeBat = new CompositeBat();

            chuck.TakeTurn(WoodenBat);
            chuck.TakeTurn(AluminumBat);
            chuck.TakeTurn(CompositeBat);
        }
    }
}

