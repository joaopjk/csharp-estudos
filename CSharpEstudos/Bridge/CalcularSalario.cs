namespace Bridge
{
    internal class CalcularSalario(IGerarArquivo gerarArquivo) : Arquivo(gerarArquivo)
    {
        public void ProcessarSalarioFuncionario(Funcionario funcionario)
        {
            funcionario.SalarioTotal = funcionario.SalarioBase * funcionario.Incentivo;
            Console.WriteLine($"Valor do salário para o funcionário: {funcionario.Nome} \n R${funcionario.SalarioTotal}");
            GerarArquivo.GerarArquivo(funcionario);
        }
    }
}
