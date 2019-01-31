using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FristHotel
{
    public class People : Waiter
    {
        public void GetWaiterInfo()
        {
            SetWaiterToOne();
            SetWaiterToZero();

            int selectedNum = 0;
            Waiter waiter = new Waiter();
            selectedNum = waiter.electedWaiterNum;

        }
    }
}
