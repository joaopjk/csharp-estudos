using TemplateMethod;

VideoPlayer arquivoVideo = new VideoMp4();
arquivoVideo.ExecutarVideo();

arquivoVideo = new VideoMkv();
arquivoVideo.ExecutarVideo();