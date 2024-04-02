using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace StoreNS{
    public abstract class Platform{
        internal List<Game> Games {get; set; }
        public Platform()
        {
            Games = new List<Game>();
            
        }
        protected Platform(Platform platform)
        {
            Games = new List<Game>(platform.Games);
        }

        public abstract void Introduction();
        public abstract int Selection();
        public virtual void Payment(int totalAmount){}
        public virtual void Change(int changeAmount){}
        public virtual void Deliver(){}

    }
}