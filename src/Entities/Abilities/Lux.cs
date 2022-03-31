namespace Game.Project.src.Entities
{
    public class Lux : Champion
    {
        public Lux(string Name, string Role, string Region, int Difficulty)
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
            return this.Name + " releases a sphere of light that binds and deals damage to up to two enemy units.";
        }
        public override string W()
        {
            return this.Name + " throws her wand and bends the light around any friendly target it touches, protecting them from enemy damage.";
        }
        public override string E()
        {
            return this.Name + " fires an anomaly of twisted light to an area, which slows nearby enemies, detonating it to damage enemies in the area of effect.";
        }
        public override string Ultimate()
        {
            return this.Name + " fires a beam of light that deals damage to all targets in the area. In addition, triggers Lux's passive ability and refreshes the Illumination debuff duration.";
        }
        public string Passive(int Bonus)
        {
            if(Bonus >= 3)
            {
                return this.Name + "'s next attack ignites the energy, dealing bonus magic damage of " + Bonus + ".";
            }
            else
            {
                return this.Name + "'s energy is charging, bonus in " + Bonus + ".";
            }
        }
    }
}