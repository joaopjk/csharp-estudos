namespace AbstractFactory
{
    internal interface IMontadora
    {
        ISuv CriarSuv();
        ISedan CriarSedan();
    }
}
