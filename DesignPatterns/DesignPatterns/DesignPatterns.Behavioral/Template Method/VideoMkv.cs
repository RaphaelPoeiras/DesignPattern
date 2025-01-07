namespace DesignPatterns.Behavioral.Template_Method
{
    public class VideoMkv : VideoPlayer
    {
        public override void DecoderVideo()
        {
            Console.WriteLine("Decoder de video MKV");
        }
    }
}