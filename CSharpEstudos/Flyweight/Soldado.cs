namespace Flyweight
{
    internal class Soldado : IPersonagem
    {
        // Estado extrínseco(não compartilhado)
        public int Poder { get; set; }
        // Estado intrínseco(compartilhado)
        public string Defesa = "Colete e capacete";
        public string Atuacao = "Luta Corporal";
        public string Arma = "Fuzil e Pistola";

        public Soldado() { }

        public Soldado(int poder)
        {
            if (poder is >= 10 and <= 50)
                Poder = poder;
            else
                throw new ArgumentException("Valor está fora do poder de um soltado");
        }
        public void Render()
        {
            Console.WriteLine($"Soldado: Poder {Poder} - Arma: {Arma} - Defesa: {Defesa} - Atuação: {Atuacao}");
        }
    }
}
