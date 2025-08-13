using Mediator;

var facebookMediator = new ConcreteFacebookGrouMediator();

var joao = new ConcreteUser(facebookMediator, "João");
var maria = new ConcreteUser(facebookMediator, "Maria");
var jose = new ConcreteUser(facebookMediator, "José");
var pedro = new ConcreteUser(facebookMediator, "Pedro");
var ana = new ConcreteUser(facebookMediator, "Ana");

facebookMediator.RegisterUser(joao);
facebookMediator.RegisterUser(maria);
facebookMediator.RegisterUser(jose);
facebookMediator.RegisterUser(pedro);
facebookMediator.RegisterUser(ana);

joao.Send("Olá, pessoal!");
maria.Send("Oi, João!");
jose.Send("Oi, João! Oi, Maria!");
pedro.Send("Oi, pessoal! Tudo bem?");
ana.Send("Oi, pessoal! Tudo bem?");
