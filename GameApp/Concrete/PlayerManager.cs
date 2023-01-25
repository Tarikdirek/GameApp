using GameApp.Abstract;
using GameApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Concrete
{
    public class PlayerManager : IServiceManager, IPlayerService
    {
        

        public void Add(Player player)
        {    if (CheckIfRealPerson(player)) 
            {
                Console.WriteLine(player.Name + ", your account accepted and added.");
            }
            else 
            {
                throw new Exception("Not a valid person");
            }                    
            
        }
        public void Save(Player player) 
        { 
            
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine(entity.Name + " your account deleted.");
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine(entity.Name + " your account updated.");
        }

        public bool CheckIfRealPerson(Player player)
        {
            return true;
        }
    }
}
