namespace Adapter
{
    internal class SistemaEscolar
    {
        public static string[,] GetListaAlunosMensalidades()
        {
            return new string[5, 4]
            {
                {"101","Maria","Artes","1000" },
                {"102","Pedro","Programação","2000" },
                {"103","João","Veterinária","3000" },
                {"104","Pamela","Psicologia","4000" },
                {"105","Sergio","Desenho","850" }
            };
        }
    }
}
