using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBall1
{
    public interface IBaseBallBat
    {
        int WeightInGrams { get; set; } 

        void Swing();
    }
}
