namespace AbstractFactory
{
    internal class FabricaHonda : IMontadora
    {
        public ISuv CriarSuv() => new HondaCrv();

        public ISedan CriarSedan() => new HondaCivic();
    }
}
