namespace Game.Project.src.Entities
{
    public abstract class Champion
    {
        public Champion(string Name, string Role, string Region, int Difficulty)
        {
            this.Name = Name;
            this.Role = Role;
            this.Region = Region;
            this.Difficulty = Difficulty;
        }

        public Champion(){}
        public string Name;
        public string Role;
        public string Region;
        public int Difficulty;

        public override string ToString()
        {
            return this.Name + " " + this.Role + " " + this.Region + " " + this.Difficulty;
            
        }
        public virtual string Passive()
        {
            return this.Name + " ";
        }
        public virtual string Q()
        {
            return this.Name + " ";
        }
        public virtual string W()
        {
            return this.Name + " ";
        }
        public virtual string E()
        {
            return this.Name + " ";
        }
        public virtual string Ultimate()
        {
            return this.Name + " ";
        }
    }
}