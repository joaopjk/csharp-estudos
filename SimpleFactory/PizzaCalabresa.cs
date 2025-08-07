namespace SimpleFactory
{
    internal class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa()
        {
            Nome = "Calabresa";
        }
        public override void Preparar()
        {
            Console.WriteLine($"Preparando pizza de {Nome}");
        }

        public override void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} assando por {tempo}");
        }

        public override void Embalar()
        {
            Console.WriteLine($"Embalando pizza de {Nome}");
        }
    }
}
