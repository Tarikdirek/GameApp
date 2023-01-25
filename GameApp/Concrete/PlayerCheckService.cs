using GameApp.Abstract;
using GameApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Concrete
{
    public class PlayerCheckService : IPlayerService
    {
        public bool CheckIfRealPerson(Player player)
        {
            return true;
        }
    }
}
