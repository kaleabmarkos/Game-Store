using System.Runtime.CompilerServices;
using StoreNS;

namespace StoreNS{
    public class Switch:Platform{
        public Switch()
        {
        
        }
        public Switch(Switch switchobj) : base(switchobj) { }

        protected override void Introduction()
        {
            Console.WriteLine("Welcome to Swich Game Store!");
        }
        
        protected override void Change()
        {
        }
        
    }
}