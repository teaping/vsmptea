using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaLou.GuanSz
{
    class Moues
    {
        /// <summary>
        /// 移入
        /// </summary>
        /// <param name="a"></param>
        public void MouseJr(ButtonEx a)
        {
            a.FlatAppearance.BorderSize = 1;
             a.FlatStyle = System.Windows.Forms.FlatStyle.System;
        }
        //移出
        public void MouseCr(ButtonEx a)
        {
            a.FlatAppearance.BorderSize = 0;
            a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
;
        }
    }
}
