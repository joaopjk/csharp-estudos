namespace Flyweight
{
    internal class Piloto : IPersonagem
    {
        // Estado extrínseco(não compartilhado)
        public int Poder { get; set; }
        // Estado intrínseco(compartilhado)
        public string Defesa = "Velocidade e Altitude";
        public string Atuacao = "Combate Aéreo";
        public string Arma = "AMX A1: Bombas/Metralhadora";

        public Piloto() { }

        public Piloto(int poder)
        {
            if (poder is >= 20 and <= 100)
                Poder = poder;
            else
                throw new ArgumentException("Valor está fora do poder de um Piloto");
        }
        public void Render()
        {
            Console.WriteLine($"Piloto: Poder {Poder} - Arma: {Arma} - Defesa: {Defesa} - Atuação: {Atuacao}");
        }
    }
}
