namespace DesignPatterns.Behavioral.Interpreter
{
    public class Separador : AbstractExpression
    {
        public void Avaliar(Context context)
        {
            string expressao = context.Expressao;
            context.Expressao = expressao.Replace(" ", "-");
        }
    }
}