namespace Interpreter
{
    internal class ExpressaoMes : IAbstractExpression
    {
        public void Avaliar(Context context)
        {
            var expressao = context.Expressao;
            context.Expressao = expressao.Replace("MM", context.Data.Month.ToString());
        }
    }
}
