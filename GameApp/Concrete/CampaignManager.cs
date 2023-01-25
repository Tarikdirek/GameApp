using GameApp.Abstract;
using GameApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Concrete
{
    public class CampaignManager : IServiceManager
    {
        

        public void Add(IEntity entity)
        {
            Console.WriteLine(entity.Name + " campaign added!");
        }
        public void Add(Player player) 
        {
            Console.WriteLine(player.Name + " campaign added!");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine(entity.Name + " campaign deleted!");
        }
        public double CalculateDiscount(Campaign campaign, Game game) 
        {
            double campaignPrice= game.Price * campaign.DiscountRate;
            return campaignPrice; 
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine(entity.Name + " campaign updated!");
        }
    }
}
