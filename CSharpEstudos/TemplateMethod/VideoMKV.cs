namespace TemplateMethod
{
    internal class VideoMkv : VideoPlayer
    {
        public override void DecodificarVideo()
        {
            Console.WriteLine("O vídeo está sendo processado com o Decoder MKV");
        }
    }
}
