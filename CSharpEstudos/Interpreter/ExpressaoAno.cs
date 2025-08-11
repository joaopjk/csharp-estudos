namespace Interpreter
{
    internal class ExpressaoAno : IAbstractExpression
    {
        public void Avaliar(Context context)
        {
            var expressao = context.Expressao;
            context.Expressao = expressao.Replace("YYYY", context.Data.Year.ToString());
        }
    }
}
