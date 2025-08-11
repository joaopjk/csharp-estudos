using Interpreter;

var expressoes = new List<IAbstractExpression>();
var context = new Context(DateTime.Now);

Console.WriteLine("Selecione a expressão a usar: MM-DD-YYYY ou YYYY-MM-DD ou DD-MM-YYYY");
context.Expressao = "MM-DD-YYYY";

var formato = context.Expressao.Split('-');
foreach (var item in formato)
{
    switch (item)
    {
        case "DD":
            expressoes.Add(new ExpressaoDia());
            break;
        case "MM":
            expressoes.Add(new ExpressaoMes());
            break;
        case "YYYY":
            expressoes.Add(new ExpressaoAno());
            break;
        default:
            throw new Exception("Formato inválido");
    }
}
expressoes.Add(new Separador());

foreach (var item in expressoes)
{
    item.Avaliar(context);
}

Console.WriteLine($"Data na expressão escolhida: {context.Expressao}");