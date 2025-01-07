namespace DesignPatterns.Structural.Flyweight
{
    public class ExecutorFlyweight
    {
        public void Execute()
        {
            for (int i = 0; i < 5; i++)
            {
                var personagem = (Infantaria)SoldadoFactory.GetPersonagem("infantaria");
                personagem.Poder = getRandomPoder(11, 49);
                personagem.Render();
            }

            for (int i = 0; i < 5; i++)
            {
                var personagem = (Piloto)SoldadoFactory.GetPersonagem("piloto");
                personagem.Poder = getRandomPoder(20, 100);
                personagem.Render();
            }
        }

        public int getRandomPoder(int inicio, int fim)
        {
            Random rand = new Random();
            return rand.Next(inicio, fim);
        }
    }
}