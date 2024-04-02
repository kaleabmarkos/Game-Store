using StoreNS;

namespace StoreNS{
    public class Game{
        public string? Name {get; set;} = "";
        public int _price = 0;
        public int Price{
            get => _price;
            set => _price = value >= 0 ? value : 0;
        }
        public int Units { get; set; } = 0;
        public Game() { }
        public Game(Game game) //copy constractor
        {
            Name = game.Name;
            Price = game.Price;
            Units = game.Units;
        }
        public Game(string name, int price, int units) //parametrized constractor
        {
            Name = name;
            Price = price;
            Units = units;
        }
    }
}