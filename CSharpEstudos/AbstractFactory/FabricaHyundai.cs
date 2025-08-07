namespace AbstractFactory
{
    internal class FabricaHyundai : IMontadora
    {
        public ISuv CriarSuv() => new CretaHyundai();

        public ISedan CriarSedan() => new Hb20Hyundai();
    }
}
