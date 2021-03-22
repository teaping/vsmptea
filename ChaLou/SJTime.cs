using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaLou
{
    /// <summary>
    /// 计算时间
    /// </summary>
    class SJTime
    {
        //封装时间
        private DateTime a;
        //从构造方法传数值过来设置a
        public SJTime(DateTime b)
        {
            this.a = b;
        }
        //返回时间 （进店时间-现在时间）已用时间
        public DateTime SjTime01()
        {
            DateTime dq = new DateTime();
            DateTime fhsj = new DateTime();
            dq = DateTime.Now.ToLocalTime();
            TimeSpan sjj = dq - a;
            return  fhsj.Add(sjj);
        }
    }
}
