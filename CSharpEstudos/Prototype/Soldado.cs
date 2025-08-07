namespace Prototype
{
    internal class Soldado : ICloneable
    {
        public string Nome { get; set; }
        public string Arma { get; set; }

        public Soldado() { }
        public Soldado(Soldado soldado)
        {
            Nome = soldado.Nome;
            Arma = soldado.Arma;
        }
        public object Clone()
        {
            return new Soldado(this);
        }
    }
}
