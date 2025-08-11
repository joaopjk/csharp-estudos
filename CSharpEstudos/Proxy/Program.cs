using Proxy;

var funcionarioProgramador = new Funcionario("João", "Programador");
var funcionarioCeo = new Funcionario("João", "Ceo");

var pastaCompartilhadaProgramador = new PastaCompartilhadaProxy(funcionarioProgramador);
pastaCompartilhadaProgramador.OperacaoLeituraGravacao();
var pastaCompartilhadaCeo = new PastaCompartilhadaProxy(funcionarioCeo);
pastaCompartilhadaCeo.OperacaoLeituraGravacao();