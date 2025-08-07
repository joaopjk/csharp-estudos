using System.Collections;
using System.Text;

namespace FactoryMethod
{
    internal abstract class Pizza
    {
        protected string Nome { get; set; }
        protected string Massa;
        protected string Molho;
        protected ArrayList Ingredientes = new();

        public string Preparar()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Preparando {Nome}");
            sb.AppendLine($"Massa: {Massa}");
            sb.AppendLine($"Molho: {Molho}");
            foreach (var ingrediente in Ingredientes)
            {
                sb.AppendLine($"{ingrediente}");
            }
            sb.AppendLine(Cozinhar());
            sb.AppendLine(Fatiar());
            sb.AppendLine(Embalar());

            return sb.ToString();
        }

        internal virtual string Embalar() => "Embalando a pizza";

        internal virtual string Fatiar() => "Fatiar a pizza em 8 pedaços";

        internal virtual string Cozinhar() => "Cozinhar por 25 minutos a 350 graus";
    }
}
