namespace DesignPatterns.Behavioral.Template_Method
{
    public class VideoMp4 : VideoPlayer
    {
        public override void DecoderVideo()
        {
            Console.WriteLine("Decoder de video NP4");
        }
    }
}