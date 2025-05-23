using System.Globalization;
using System.Xml.Linq;

namespace LearningClass02
{
    internal class Product
    {
        private string _name;
        public double Price { get; private set; }
        public int Amount { get; private set; }

        public Product()
        {
            Amount = 10;
        }
        public Product(string name, double price) : this()
        {
            _name = name;
            Price = price;
        }

        public Product( string name, double price, int amount) : this(name, price)
        {
            Amount = amount;
        }

        public string Name
        {
            get { return _name; }
            set {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Amount * Price;
        }


        public void AdicionarProdutos(int variableAmount)
        {
            Amount += variableAmount;
        }

        public void RemoverProdutos(int variableAmount)
        {
            Amount -= variableAmount;
        }

        public override string ToString()
        {
            return $"{_name}, R$ {Price.ToString("F2", CultureInfo.InvariantCulture)}, {Amount} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
