namespace Exercise01.Entities
{
    internal class LogRecord
    {
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(obj is not LogRecord other) return false;
            return Username.Equals(other.Username);
        }
    }
}
