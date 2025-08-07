using AbstractFactory;

var fabricaHonda = new FabricaHonda();
var sedanHonda = fabricaHonda.CriarSedan();
var suvHonda = fabricaHonda.CriarSuv();
Console.WriteLine(sedanHonda.ExibirDetalhes());
Console.WriteLine(suvHonda.ExibirDetalhes());

var fabricaHyundai = new FabricaHyundai();
var sedanHyundai = fabricaHyundai.CriarSedan();
var suvHyundai = fabricaHyundai.CriarSuv();
Console.WriteLine(sedanHyundai.ExibirDetalhes());
Console.WriteLine(suvHyundai.ExibirDetalhes());
