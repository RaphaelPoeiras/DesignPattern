using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Template_Method
{
    public class ExecutorTemplateMethod
    {
        public void Execute()
        {
            Console.WriteLine("Template Method");
            Console.WriteLine("Iniciando execução vídeo MP4");
            VideoPlayer player = new VideoMp4();
            player.ExecutarVideo();

            Console.WriteLine("Iniciando execução vídeo MKV");
            player = new VideoMkv();
            player.ExecutarVideo();
        }
    }
}
