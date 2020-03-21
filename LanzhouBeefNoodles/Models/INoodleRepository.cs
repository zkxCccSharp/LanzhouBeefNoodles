using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public interface INoodleRepository
    {
        /// <summary>
        /// 获取所以面条
        /// </summary>
        /// <returns></returns>
        IEnumerable<Noodle> GetAllNoodles();

        /// <summary>
        /// 获取某种面条
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Noodle GetNoodleById(int id);
    


    }
}
