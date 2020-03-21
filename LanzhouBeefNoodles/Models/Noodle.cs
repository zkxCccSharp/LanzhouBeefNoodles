using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public class Noodle
    {
        public int Id { get; set; }

        public string Name{ get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string ShortDescription { get; set; }

        /// <summary>
        /// 详情
        /// </summary>
        public string LongDescription { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string ImageUrl { get; set; }

        public bool IsInStock { get; set; }
    
    }
}
