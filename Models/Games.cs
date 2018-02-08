using System.Collections.Generic;
using Tamagotchis.Models;

namespace Games.Models
{
    public static class Game
    {
        private static List<Tamagotchi> _instances = new List<Tamagotchi> {};

        public static List<Tamagotchi> GetAll()
       {
           return _instances;
       }

       public void Save()
       {
           _instances.Add(this);
       }

   }
}
