using GameApp.Abstract;
using GameApp.Concrete;
using GameApp.Entity;

internal class Program
{
    private static void Main(string[] args)
    {
        Game game1 = new Game 
        { 
            Id= 1,
            Name = "Sin",
            Price= 100,
            Type ="Action"       
        };

        Campaign campaign1 = new Campaign
        {
            Id = 1,
            Name = "Winter Sale",
            DiscountRate = 0.1,
            ValidDate= new DateTime(2023,4,10),
            InvalidDate = new DateTime(2023,6,6),        
        };

        Player player1 = new Player {Id=1, Name="Tarık",LastName="Direk", DateOfBirth = new DateTime(1997,5,15) };
        


        SalesManager manager1 = new SalesManager();
        manager1.Add(player1);

        Console.WriteLine();

        PlayerManager playerManager = new PlayerManager();
        playerManager.Add(player1);
        


        Console.WriteLine();
        
        CampaignManager campaignManager1 = new CampaignManager();
        campaignManager1.Add(campaign1);
        campaignManager1.Delete(campaign1);
        campaignManager1.Update(campaign1);
        Console.WriteLine();
        
        Console.WriteLine($"{campaign1.Name} " + "campaign discount rate % " +campaignManager1.CalculateDiscount(campaign1,game1));

        Console.WriteLine();
        SalesManager salesManager1 = new SalesManager();
        salesManager1.ApplyCampaign(campaignManager1,game1,campaign1);

        
        
        

    }
}