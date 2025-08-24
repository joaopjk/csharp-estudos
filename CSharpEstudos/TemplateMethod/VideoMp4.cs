namespace TemplateMethod
{
    internal class VideoMp4 : VideoPlayer
    {
        public override void DecodificarVideo()
        {
            Console.WriteLine("O vídeo está sendo processado com o Decoder MP4");
        }
    }
}
