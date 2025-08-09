namespace Composite
{
    // Component
    internal abstract class HoraTrabalhada
    {
        public string Nome { get; set; }
        public virtual void Add(HoraTrabalhada horaTrabalhada) { }
        public abstract int GetHoraTrabalhada();
    }
}
