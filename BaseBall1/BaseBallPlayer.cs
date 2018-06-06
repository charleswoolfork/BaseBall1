using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBall1
{
    public class BaseBallPlayer
    {
        private object bat;

        public string name { get; set; }
        public string Number { get; set; }

        public void TakeTurn(IBaseBallBat bat)
        {
         bat.Swing();
        }

        internal void TakeTurn(object compositeBat)
        {
            throw new NotImplementedException();
        }
    }
}
   
   




