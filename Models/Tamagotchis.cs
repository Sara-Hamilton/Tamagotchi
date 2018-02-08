using System.Collections.Generic;

namespace Tamagotchis.Models
{
    public class Tamagotchi
    {
        private string _name;
        private int _hunger;
        private int _play;
        private int _rest;
        private static List<Tamagotchi> _instances = new List<Tamagotchi> {};

        public Tamagotchi()
        {
            _hunger = 5;
            _play = 5;
            _rest = 5;
        }

        public string GetName()
        {
            return _name;
        }
        public void SetName(string newName)
        {
            _name = newName;
        }

        public int GetHunger()
        {
            return _hunger;
        }
        public void SetHunger(int newHunger)
        {
            _hunger = newHunger;
        }

        public int GetPlay()
        {
            return _play;
        }
        public void SetPlay(int newPlay)
        {
            _play = newPlay;
        }

        public int GetRest()
        {
            return _rest;
        }
        public void SetRest(int newRest)
        {
            _rest = newRest;
        }

        public static List<Tamagotchi> GetAll()
        {
           return _instances;
        }

        public void Save()
        {
           _instances.Add(this);
        }

        public void Feed()
        {
            _hunger ++;

        }

        public void Attend()
        {
            _play++;
        }

        public void Sleep()
        {
            _rest++;
        }

        public void Time()
        {
            _hunger--;
            _play--;
            _rest--;
        }
    }
}
