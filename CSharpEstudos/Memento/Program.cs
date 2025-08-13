using Memento;

var calculadora = new Calculadora();
calculadora.SetPrimeiroNumero(10);
calculadora.SetSegundoNumero(20);
Console.WriteLine($"Resultado: {calculadora.GetCalculoResultado()}");

var memento = calculadora.BackupUltimoCalculo();

calculadora.SetPrimeiroNumero(30);
calculadora.SetSegundoNumero(40);
Console.WriteLine($"Novo Resultado: {calculadora.GetCalculoResultado()}");

calculadora.RestaurarUltimoCalculo(memento);
Console.WriteLine($"Novo Resultado: {calculadora.GetCalculoResultado()}");