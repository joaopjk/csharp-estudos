namespace Composite
{
    // Composite
    internal class Organizacao : HoraTrabalhada
    {
        protected readonly List<HoraTrabalhada> Departamentos = [];
        public override void Add(HoraTrabalhada horaTrabalhada)
        {
            Departamentos.Add(horaTrabalhada);
        }
        public override int GetHoraTrabalhada()
        {
            var horasTrabalhadasDepartamento = Departamentos.Sum(departamento => departamento.GetHoraTrabalhada());

            Console.WriteLine($"{Nome} registrou um total de {horasTrabalhadasDepartamento}");
            return horasTrabalhadasDepartamento;
        }
    }
}
