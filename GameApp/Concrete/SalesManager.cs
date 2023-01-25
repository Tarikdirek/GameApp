using GameApp.Abstract;
using GameApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Concrete
{
    public class SalesManager : IServiceManager
    {
        

        public void Add(IEntity entity)
        {
            Console.WriteLine($"{entity.Name}" + ", your purchaise added on your library.");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine($"{entity.Name}" + ", your purchaise deleted from your library.");
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine($"{entity.Name}" + ", your purchaise updated.");
        }
        public void ApplyCampaign(CampaignManager campaign, Game game, Campaign campaign1) 
        {
            double calculate = campaign.CalculateDiscount(campaign1, game);
            Console.WriteLine(calculate + "$ discount applied on your purchase. New price: "+ (game.Price-calculate)+"$"); 
        }


    }
}
