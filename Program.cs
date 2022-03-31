using static System.Console;
using Game.Project.src.Entities;

class Program
{
    static void Main(string[] args)
    {
       Akali akali = new Akali("Akali", "Assassin", "Ionia", 2);
       Fiora fiora = new Fiora("Fiora", "Fighter", "Demacia", 1);
       Lux lux = new Lux("Lux", "Mage", "Demacia", 2);
       Poppy poppy = new Poppy("Poppy", "Tank", "Demacia", 2);
       Sona sona = new Sona("Sona", "Support", "Demacia", 2);
       Vayne vayne = new Vayne("Vayne", "Marksman", "Demacia", 3);
       
       
       WriteLine("-----------------");
       WriteLine("Akali's Abilities");
       WriteLine("-----------------");
       WriteLine("Role: " +akali.Role + " " + "Region: " + akali.Region + " " + "Difficulty: "+  akali.Difficulty);
       WriteLine(" ");
       WriteLine("Passive: " + akali.Passive(1));
       WriteLine(" ");
       WriteLine("Q: " + akali.Q());
       WriteLine(" ");
       WriteLine("W: " + akali.W());
       WriteLine(" ");
       WriteLine("E: " + akali.E());
       WriteLine(" ");
       WriteLine("Ultimate: " + akali.Ultimate());
       WriteLine(" ");
       WriteLine(" ");
       
       WriteLine("-----------------");
       WriteLine("Fiora's Abilities");
       WriteLine("-----------------");
       WriteLine("Role: " + fiora.Role + " " + "Region: " +  fiora.Region + " " + "Difficulty: "+   fiora.Difficulty);
       WriteLine(" ");
       WriteLine("Passive: " + fiora.Passive(2));
       WriteLine(" ");
       WriteLine("Q: " + fiora.Q());
       WriteLine(" ");
       WriteLine("W: " + fiora.W());
       WriteLine(" ");
       WriteLine("E: " + fiora.E());
       WriteLine(" ");
       WriteLine("Ultimate: " + fiora.Ultimate());
       WriteLine(" ");
       WriteLine(" ");
       
       WriteLine("-----------------");
       WriteLine("Lux's Abilities");
       WriteLine("-----------------");
       WriteLine("Role: " + lux.Role + " " + "Region: " +  lux.Region + " " + "Difficulty: "+   lux.Difficulty);
       WriteLine(" ");
       WriteLine("Passive: " + lux.Passive(3));
       WriteLine(" ");
       WriteLine("Q: " + lux.Q());
       WriteLine(" ");
       WriteLine("W: " + lux.W());
       WriteLine(" ");
       WriteLine("E: " + lux.E());
       WriteLine(" ");
       WriteLine("Ultimate: " + lux.Ultimate());
       WriteLine(" ");
       WriteLine(" ");

       WriteLine("-----------------");
       WriteLine("Poppy's Abilities");
       WriteLine("-----------------");
       WriteLine("Role: " + poppy.Role + " " + "Region: " +  poppy.Region + " " + "Difficulty: "+   poppy.Difficulty);
       WriteLine(" ");
       WriteLine("Passive: " + poppy.Passive(3));
       WriteLine(" ");
       WriteLine("Q: " + poppy.Q());
       WriteLine(" ");
       WriteLine("W: " + poppy.W());
       WriteLine(" ");
       WriteLine("E: " + poppy.E());
       WriteLine(" ");
       WriteLine("Ultimate: " + poppy.Ultimate());
       WriteLine(" ");
       WriteLine(" ");
       
       WriteLine("-----------------");
       WriteLine("Sona's Abilities");
       WriteLine("-----------------");
       WriteLine("Role: " + sona.Role + " " + "Region: " + sona.Region + " " + "Difficulty: "+  sona.Difficulty);
       WriteLine(" "); 
       WriteLine("Passive: " + sona.Passive(2));
       WriteLine(" ");
       WriteLine("Q: " + sona.Q());
       WriteLine(" ");
       WriteLine("W: " + sona.W());
       WriteLine(" ");
       WriteLine("E: " + sona.E());
       WriteLine(" ");
       WriteLine("Ultimate: " + sona.Ultimate());
       WriteLine(" ");
       WriteLine(" ");

       WriteLine("-----------------");
       WriteLine("Vayne's Abilities");
       WriteLine("-----------------");
       WriteLine("Role: " + vayne.Role + " " + "Region: " + vayne.Region + " " + "Difficulty: "+  vayne.Difficulty);
       WriteLine(" ");
       WriteLine("Passive: " + vayne.Passive(1));
       WriteLine(" ");
       WriteLine("Q: " + vayne.Q());
       WriteLine(" ");
       WriteLine("W: " + vayne.W());
       WriteLine(" ");
       WriteLine("E: " + vayne.E());
       WriteLine(" ");
       WriteLine("Ultimate: " + vayne.Ultimate());
       WriteLine(" ");
       
    }
}