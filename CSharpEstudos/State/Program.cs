using State;

var caixaEletronico = new CaixaEletronico();

Console.WriteLine($"Estado atual do Caixa Eletrônico: {caixaEletronico.GetType().Name}");
caixaEletronico.InserirSenha();
caixaEletronico.SacarDinheiro();
caixaEletronico.EjetarCartao();
caixaEletronico.InserirCartao();
Console.WriteLine();

Console.WriteLine($"Estado atual do Caixa Eletrônico: {caixaEletronico.GetType().Name}");
caixaEletronico.InserirSenha();
caixaEletronico.SacarDinheiro();
caixaEletronico.EjetarCartao();
caixaEletronico.InserirCartao();
Console.WriteLine();

Console.WriteLine($"Estado atual do Caixa Eletrônico: {caixaEletronico.GetType().Name}");