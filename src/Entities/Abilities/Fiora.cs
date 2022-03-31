namespace Game.Project.src.Entities
{
    public class Fiora : Champion
    {
        public Fiora(string Name, string Role, string Region, int Difficulty)
        {
            this.Name = Name;
            this.Role = Role;
            this.Region = Region;
            this.Difficulty = Difficulty;
        }
        public override string Passive()
        {
            return this.Name + "'s passive is charging.";
        }
        public override string Q()
        {
            return this.Name + " lunges in a direction and stabs a nearby enemy, dealing physical damage and applying on-hit effects.";
        }
        public override string W()
        {
            return this.Name + " parries all incoming damage and disables for a short time, then stabs in a direction. This stab slows the first enemy champion hit, or stuns them if Fiora blocked an immobilizing effect with this ability.";
        }
        public override string E()
        {
            return this.Name + " has increased attack speed for the next two attacks. The first attack slows the target, and the second attack will critically strike.";
        }
        public override string Ultimate()
        {
            return this.Name + " reveals all four Vitals on an enemy champion and gains Move Speed while near them. If Fiora hits all 4 Vitals or if the target dies after she has hit at least one, Fiora and her allies in the area are healed over the next few seconds.";
        }
        public string Passive(int Bonus)
        {
            if(Bonus >= 3)
            {
                return this.Name + " challenges nearby enemy Champions to dodge her. She calls out a direction from which she will try to strike. If she can complete her own challenge, she receives a small bonus of " + Bonus + ".";
            }
            else
            {
                return this.Name + "'s energy is charging, bonus in " + Bonus + ".";
            }
        }
    }
}