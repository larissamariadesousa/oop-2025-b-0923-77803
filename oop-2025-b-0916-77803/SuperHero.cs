using System;

namespace oop_2025_b_0916_77803.Models
{
    public abstract class Being
    {
        protected Being(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public string Name { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;

        public virtual string Describe()
        {
            return $"{Name} is a {Species}";
        }
    }

    public abstract class SuperHero : Being
    {
        protected SuperHero(string name, string species, string alias, string team) 
            : base(name, species)
        {
            Alias = alias;
            Team = team;
        }

        public string Alias { get; set; } = string.Empty;
        public string Team { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{Name} ({Alias}) - Team: {Team}";
        }
    }

    public class HumanHero : SuperHero
    {
        public HumanHero(string name, string alias, string team)
            : base(name, "Human", alias, team)
        {
        }
    }
}