using Adapter;

var alunosArray = SistemaEscolar.GetListaAlunosMensalidades();
var sistemaMensalidade = new SistemaMensalidade();

var calculo = new AlunosAdapter();
calculo.ProcessaCalculoMensalidade(alunosArray);