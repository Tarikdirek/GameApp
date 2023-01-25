using GameApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Entity
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double DiscountRate  { get; set; }
        public DateTime ValidDate { get; set; }
        public DateTime InvalidDate { get; set; }

    }
}
