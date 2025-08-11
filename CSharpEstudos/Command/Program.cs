using Command;

var chef = new Chef();

var pedido = new Pedido(chef, "Prato");
var garcom = new Garcom(pedido);
garcom.Executa();

pedido = new Pedido(chef, "Sobremesa");
garcom = new Garcom(pedido);
garcom.Executa();