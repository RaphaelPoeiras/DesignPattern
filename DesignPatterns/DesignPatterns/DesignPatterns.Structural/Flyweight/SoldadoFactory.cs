namespace DesignPatterns.Structural.Flyweight
{
    public class SoldadoFactory
    {
        private static Dictionary<string, Soldado> personagemMap = new Dictionary<string, Soldado>();

        public static Soldado GetPersonagem(string tipo)
        {
            Soldado soldado;

            if (personagemMap.ContainsKey(tipo))
            {
                Console.WriteLine($">>>>> Retornando personagem to cache : {tipo} >>>");
                return personagemMap[tipo];
            }
            else
            {
                Console.WriteLine($">>>>> Criando novo personagem : {tipo} >>>");
                if (tipo == "infantaria")
                {
                    soldado = new Infantaria();
                    personagemMap.Add("infantaria", soldado);
                }
                else if (tipo =="piloto")
                {
                    soldado = new Piloto();
                    personagemMap.Add("piloto", soldado);
                }
                else
                {
                    throw new Exception("Tipo inválido");
                }
            }

            return soldado;
        }
    }
}