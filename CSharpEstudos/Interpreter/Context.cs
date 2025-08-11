namespace Interpreter
{
    internal class Context(DateTime data)
    {
        public DateTime Data { get; } = data;
        public string Expressao { get; set; }
    }
}
