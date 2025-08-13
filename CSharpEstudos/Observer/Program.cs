using Observer;

var iphone16 = new ConcreteSubject("Phone16", 4900, "Sem Estoque");

var joao = new ConcreteObserver("João", iphone16);
var maria = new ConcreteObserver("Maria", iphone16);
var pedro = new ConcreteObserver("Pedro", iphone16);

iphone16.SetDisponibilidade("Disponível");