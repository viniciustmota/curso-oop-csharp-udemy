namespace DiamantProblem.Devices
{
    internal class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"Printer processing: {document}");
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
