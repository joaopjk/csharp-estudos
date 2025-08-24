using Visitor;

var lojas = new List<ILoja>();
var carros = new List<Carro>
{
    new Carro() { Nome = "Ford", Modelo = "Ka", Preco = 40000 },
    new Carro() { Nome = "Chevrolet", Modelo = "Onix", Preco = 50000 },
    new Carro() { Nome = "Fiat", Modelo = "Argo", Preco = 45000 }
};

foreach (var carro in carros)
{
    lojas.Add(carro);
}


foreach (var element in lojas)
{
    element.Visit(new PrecoVisitor());
}