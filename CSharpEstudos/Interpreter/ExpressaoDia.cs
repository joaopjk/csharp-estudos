namespace Interpreter
{
    internal class ExpressaoDia : IAbstractExpression
    {
        public void Avaliar(Context context)
        {
            var expressao = context.Expressao;
            context.Expressao = expressao.Replace("DD", context.Data.Day.ToString());
        }
    }
}
