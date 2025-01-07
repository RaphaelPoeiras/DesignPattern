namespace DesignPatterns.Behavioral.Template_Method
{
    public abstract class VideoPlayer
    {
        public virtual void CarregarVideo()
        {
            Console.WriteLine("Carregando Video");
        }

        public virtual void DecoderVideo()
        {
            Console.WriteLine("Decoder Video");
        }

        public virtual void ExecutarVideo()
        {
            CarregarVideo();
            DecoderVideo();
            IniciarVideo();
        }

        public virtual void IniciarVideo()
        {
            Console.WriteLine("Iniciar Video");
        }
    }
}