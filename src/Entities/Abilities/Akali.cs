namespace Game.Project.src.Entities
{
    public class Akali : Champion
    {
        public Akali(string Name, string Role, string Region, int Difficulty)
        {
            this.Name = Name;
            this.Role = Role;
            this.Region = Region;
            this.Difficulty = Difficulty;
        }
        public override string Passive()
        {
            return this.Name + "'s passive is charging";
        }
        public override string Q()
        {
            return this.Name + " throws out five kunai, dealing damage based on her bonus Attack Damage and Ability Power and slowing.";
        }
        public override string W()
        {
            return this.Name + " drops a cover of smoke and briefly gains Move Speed. While inside the shroud, Akali becomes invisible and unable to be selected by enemy spells and attacks. Attacking or using abilities will briefly reveal her.";
        }
        public override string E()
        {
            return this.Name + " flips backward and fire a shuriken forward, dealing magic damage. The first enemy or smoke cloud hit is marked. Re-cast to dash to the marked target, dealing additional damage.";
        }
        public override string Ultimate()
        {
            return this.Name + " leaps in a direction, damaging enemies she strikes. Re-cast: Akali dashes in a direction, executing all enemies she strikes.";
        }
        public string Passive(int Bonus)
        {
            if(Bonus >= 3)
            {
                return this.Name + " dealing spell damage to a champion creates a ring of energy around them. Exiting that ring empowers Akali's next autoattack with bonus range and damage of " + Bonus + ".";
            }
            else
            {
                return this.Name + "'s energy is charging, bonus in " + Bonus + ".";
            }
        }
    }
}