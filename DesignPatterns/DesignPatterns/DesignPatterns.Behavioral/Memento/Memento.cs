namespace DesignPatterns.Behavioral.Memento
{
    public class Memento : ICaretaker, IOriginator
    {
        private int primeiroNumero;
        private int segundoNumero;

        public Memento(int num1, int num2)
        {
            primeiroNumero = num1;
            segundoNumero = num2;
        }

        public int GetPrimeiroNumero()
        {
            return primeiroNumero;
        }

        public int GetSegundoNumero()
        {
            return segundoNumero;
        }
    }
}