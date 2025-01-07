namespace DesignPatterns.Behavioral.Interpreter
{
    public class ExpressaoMes : AbstractExpression
    {
        public void Avaliar(Context context)
        {
            string expressao = context.Expressao;
            context.Expressao = expressao.Replace("MM", context.Data.Month.ToString());
        }
    }
}