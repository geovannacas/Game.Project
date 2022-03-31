namespace Game.Project.src.Entities
{
    public class Vayne : Champion
    {
        public Vayne(string Name, string Role, string Region, int Difficulty)
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
            return this.Name + " tumbles, maneuvering to carefully place her next shot. Her next attack deals bonus damage.";
        }
        public override string W()
        {
            return this.Name + " tips her bolts with a rare metal, toxic to evil things. The third consecutive attack or ability against the same target deals a percentage of the target's max health as bonus true damage.";
        }
        public override string E()
        {
            return this.Name + " draws a heavy crossbow from her back, and fires a huge bolt at her target, knocking them back and dealing damage. If they collide with terrain, they are impaled, dealing bonus damage and stunning them.";
        }
        public override string Ultimate()
        {
            return this.Name + " readying herself for an epic confrontation, Vayne gains increased Attack Damage, Invisibility during Tumble, reduced Tumble cooldown, and more bonus Move Speed from Night Hunter";
        }
        public string Passive(int Bonus)
        {
            if(Bonus >= 3)
            {
                return this.Name + " ruthlessly hunts evil-doers, gaining 30 Move Speed when moving toward nearby enemy champions and with bonus of " + Bonus + ".";
            }
            else
            {
                return this.Name + "'s energy is charging, bonus in " + Bonus + ".";
            }
        }
    }
}