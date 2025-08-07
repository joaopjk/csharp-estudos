namespace Prototype
{
    internal class SoldadoComAcessorio : ICloneable
    {
        public string Nome { get; set; }
        public string Arma { get; set; }
        public Acessorio Acessorio { get; set; }

        public SoldadoComAcessorio() { }
        public SoldadoComAcessorio(SoldadoComAcessorio soldado)
        {
            Nome = soldado.Nome;
            Arma = soldado.Arma;
            Acessorio = soldado.Acessorio;
        }
        public object Clone()
        {
            var soldado = (SoldadoComAcessorio)this.MemberwiseClone();
            soldado.Acessorio = this.Acessorio?.Clone();
            return soldado;
        }
    }

    internal class Acessorio
    {
        public string Nome { get; set; }

        public Acessorio Clone()
        {
            return (Acessorio)this.MemberwiseClone();
        }
    }
}
