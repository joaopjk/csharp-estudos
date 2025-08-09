using Bridge;

var funcionario = new Funcionario
{
    Nome = "João",
    SalarioBase = 5000.00m,
    Incentivo = 1.2m
};

var calcularSalario = new CalcularSalario(new GerarXml());
calcularSalario.ProcessarSalarioFuncionario(funcionario);

calcularSalario = new CalcularSalario(new GerarJson());
calcularSalario.ProcessarSalarioFuncionario(funcionario);