namespace DesignPatterns.Behavioral.Interpreter
{
    public class ExpressaoDia : AbstractExpression
    {
        public void Avaliar(Context context)
        {
            string expressao = context.Expressao;
            context.Expressao = expressao.Replace("DD", context.Data.Day.ToString());
        }
    }
}