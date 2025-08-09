using Composite;

var organizacao = new Organizacao {Nome = "Pjk Inc"};

var departamentoTi = new Organizacao{Nome = "TI"};
departamentoTi.Add(new Funcionario{Nome = "João", Horas = 8});
departamentoTi.Add(new Funcionario{Nome = "Pedro", Horas = 7});
departamentoTi.Add(new Funcionario{Nome = "Maria", Horas = 8});
departamentoTi.Add(new Funcionario{Nome = "Carlos", Horas = 5});
departamentoTi.Add(new Funcionario{Nome = "Alvaro", Horas = 6});

var departamentoMarketing = new Organizacao{Nome = "Marketing"};
departamentoMarketing.Add(new Funcionario{Nome = "Ana", Horas = 8});
departamentoMarketing.Add(new Funcionario{Nome = "Beatriz", Horas = 7});
departamentoMarketing.Add(new Funcionario{Nome = "Clara", Horas = 8});

organizacao.Add(departamentoTi);
organizacao.Add(departamentoMarketing);

Console.WriteLine($"Horas totais trabalhadas na {organizacao.Nome} - {organizacao.GetHoraTrabalhada()}");