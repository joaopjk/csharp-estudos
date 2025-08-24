using Strategy;

var ctx = new CompressaoContexto(new CompressaoRar());
ctx.ComprimirArquivo("arquivo1.txt");

ctx.DefineStrategy(new CompressaoZip());
ctx.ComprimirArquivo("arquivo2.txt");

ctx.DefineStrategy(new CompressaoGzip());
ctx.ComprimirArquivo("arquivo3.txt");