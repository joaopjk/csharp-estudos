namespace Flyweight
{
    internal class PersonagemFactory
    {
        private const string Soldado = "Soldado";
        private const string Piloto = "Piloto";

        private static readonly Dictionary<string, IPersonagem> Personagens = new();
        public static IPersonagem GetPersonagem(string tipo)
        {
            if (Personagens.ContainsKey(tipo)!)
            {
                Console.WriteLine($"Retornando personagem do cache: {tipo}");
                return Personagens[tipo];
            }
            else
            {
                Console.WriteLine($"Instanciando um novo personagem: {tipo}");
                IPersonagem personagem;
                if (tipo.Equals(Soldado, StringComparison.OrdinalIgnoreCase))
                {
                    personagem = new Soldado();
                    Personagens.Add(Soldado, personagem);
                }
                else if (tipo.Equals(Piloto, StringComparison.OrdinalIgnoreCase))
                {
                    personagem = new Piloto();
                    Personagens.Add(Piloto, personagem);
                }
                else
                {
                    throw new ArgumentException("Tipo de personagem desconhecido");
                }
                return personagem;
            }
        }
    }
}
