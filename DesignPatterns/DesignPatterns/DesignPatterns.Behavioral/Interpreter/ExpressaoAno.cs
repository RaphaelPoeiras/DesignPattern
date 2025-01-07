namespace DesignPatterns.Behavioral.Interpreter
{
    public class ExpressaoAno : AbstractExpression
    {
        public void Avaliar(Context context)
        {
            string expressao = context.Expressao;
            context.Expressao = expressao.Replace("YYYY", context.Data.Year.ToString());
        }
    }
}