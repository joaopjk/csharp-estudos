using Facade;

var facade = new CreditoFacade();
var cliente = new Cliente("João da Silva");
facade.SolicitarCredito(cliente);