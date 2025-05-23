
namespace Exercise01
{
    internal class Hospede
    {

        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Email}";
        }
    }
}
