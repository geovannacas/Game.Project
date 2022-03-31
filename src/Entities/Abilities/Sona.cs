namespace Game.Project.src.Entities
{
    public class Sona : Champion
    {
        public Sona(string Name, string Role, string Region, int Difficulty)
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
            return this.Name + " plays the Hymn of Valor, sends out bolts of sound, dealing magic damage to two nearby enemies, prioritizing champions and monsters. Sona gains a temporary aura that grants allies tagged by the zone bonus damage on their next attack against enemies.";
        }
        public override string W()
        {
            return this.Name + " plays the Aria of Perseverance, sending out protective melodies, healing Sona and a nearby wounded ally. Sona gains a temporary aura that grants allies tagged by the zone a temporary shield.";
        }
        public override string E()
        {
            return this.Name + " plays the Song of Celerity, granting nearby allies bonus Move Speed. Sona gains a temporary aura that grants allied champions tagged by the zone bonus Move Speed.";
        }
        public override string Ultimate()
        {
            return this.Name + " plays her ultimate chord, stunning enemy champions and forcing them to dance and dealing magic damage to them.";
        }
        public string Passive(int Bonus)
        {
            if(Bonus >= 3)
            {
                return this.Name + "'s next attack will deal bonus magic damage or ultimate cooldown of " + Bonus + ".";
            }
            else
            {
                return this.Name + "'s energy is charging, bonus in " + Bonus + ".";
            }
        }
    }
}