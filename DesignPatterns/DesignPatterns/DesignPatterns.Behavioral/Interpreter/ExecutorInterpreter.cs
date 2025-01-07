namespace DesignPatterns.Behavioral.Interpreter
{
    public class ExecutorInterpreter
    {
        public void Execute()
        {
            List<AbstractExpression> expressions = new List<AbstractExpression>();
            Context context = new Context(DateTime.Now);

            Console.WriteLine("Selecione a expressão a usar: MM-DD-YYYY ou YYYY-MM-DD ou DD-MM-YYYY");

            context.Expressao = Console.ReadLine().ToUpper();
            string[] formato = context.Expressao.Split('-');

            foreach (string format in formato)
            {
                if (format == "DD")
                {
                    expressions.Add(new ExpressaoDia());
                }
                else if (format == "MM")
                {
                    expressions.Add(new ExpressaoMes());
                }
                else if (format == "YYYY")
                {
                    expressions.Add(new ExpressaoAno());
                }
            }

            expressions.Add(new Separador());

            foreach (var item in expressions)
            {
                item.Avaliar(context);
            }

            Console.WriteLine($"A data na expressão escolhida é: {context.Expressao}");

            Console.ReadKey();
        }
    }
}