namespace DesignPatterns.Structural.Flyweight
{
    public class Infantaria : Soldado
    {
        public int Poder {  get; set; }

        public string Defesa = "Colete e capacete";
        public string Atuacao = "Luta corporal";
        public string Arma = "Fuzil e pistola";

        public Infantaria() { }

        public Infantaria(int poder)
        {
            if (poder >= 10 && poder <= 50)
            {
                Poder = poder;
            }
            else
            {
                throw new ArgumentException("Valor incompátivel para um soldado de infantaria");
            }
        }

        public void Render()
        {
            Console.WriteLine($"Soldado: {Poder} - Arma: {Arma} - Defesa: {Defesa} - Atuação: {Atuacao}");
        }
    }
}