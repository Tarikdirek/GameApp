using GameApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Entity
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public string Type { get; set; }
        public double Price { get; set; }
    }
}
