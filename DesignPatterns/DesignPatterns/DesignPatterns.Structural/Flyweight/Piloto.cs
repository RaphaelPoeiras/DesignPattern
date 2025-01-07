namespace DesignPatterns.Structural.Flyweight
{
    public class Piloto : Soldado
    {
        public int Poder { get; set; }

        public string Defesa = "Velocidade e Altitude";
        public string Atuacao = "Combate Aéreo";
        public string Arma = "AMX A1: Bomba / Metralhadora";

        public Piloto() { }

        public Piloto(int poder)
        {
            if (poder >= 20 && poder <= 100)
            {
                Poder = poder;
            }
            else
            {
                throw new ArgumentException("Valor incompátivel para um piloto");
            }
        }

        public void Render()
        {
            Console.WriteLine($"Soldado: {Poder} - Arma: {Arma} - Defesa: {Defesa} - Atuação: {Atuacao}");
        }
    }
}