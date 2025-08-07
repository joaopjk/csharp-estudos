namespace Adapter
{
    internal class AlunosAdapter : ICalculaMensalidade
    {
        private readonly SistemaMensalidade _sistemaMensalidade = new();
        public void ProcessaCalculoMensalidade(string[,] alunosArray)
        {
            List<Aluno> listaAlunos = [];
            ConverterArrayParaLista(alunosArray, listaAlunos);
            _sistemaMensalidade.CalcularMensalidade(listaAlunos);
        }

        private static void ConverterArrayParaLista(string[,] alunosArray, List<Aluno> listaAlunos)
        {
            for (var i = 0; i < alunosArray.GetLength(0); i++)
            {
                string id = null, nome = null, mensalidade = null;
                for (var j = 0; j < alunosArray.GetLength(1); j++)
                {
                    switch (j)
                    {
                        case 0:
                            id = alunosArray[i, j];
                            break;
                        case 1:
                            nome = alunosArray[i, j];
                            break;
                        default:
                            mensalidade = alunosArray[i, j];
                            break;
                    }
                }
                listaAlunos.Add(new Aluno(Convert.ToInt32(id), nome, Convert.ToDecimal(mensalidade)));
            }
        }
    }
}
