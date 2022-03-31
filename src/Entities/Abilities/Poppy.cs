namespace Game.Project.src.Entities
{
    public class Poppy : Champion
    {
        public Poppy(string Name, string Role, string Region, int Difficulty)
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
            return this.Name + " swings her hammer, dealing damage and creating a zone that will slow enemies and explode after a delay.";
        }
        public override string W()
        {
            return this.Name + " passively gains Armor and Magic Resist. This bonus increases when she is low on Health. Poppy can activate Steadfast Presence to gain Move Speed and stop enemy dashes around her. If a dash is stopped, the enemy is slowed and grounded.";
        }
        public override string E()
        {
            return this.Name + " dashes to the target and pushes it back. If the target is pushed into a wall, it is stunned.";
        }
        public override string Ultimate()
        {
            return this.Name + " channels a hammer strike that knocks enemies very far away.";
        }
        public string Passive(int Bonus)
        {
            if(Bonus >= 3)
            {
                return this.Name + " throws her buckler that bounces off the target. Poppy can pick it up to gain a temporary shield. And with bonus of " + Bonus + ".";
            }
            else
            {
                return this.Name + "'s energy is charging, bonus in " + Bonus + ".";
            }
        }
    }
}