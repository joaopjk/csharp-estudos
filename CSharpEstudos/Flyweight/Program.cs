using Flyweight;

for (var i = 0; i < 10; i++)
{
    var soldado = (Soldado)PersonagemFactory.GetPersonagem("Soldado");
    soldado.Poder = GetRandomPoderSoldado();
    soldado.Render();
}

for (var i = 0; i < 10; i++)
{
    var piloto = (Piloto)PersonagemFactory.GetPersonagem("Piloto");
    piloto.Poder = GetRandomPoderPiloto();
    piloto.Render();
}


static int GetRandomPoderSoldado()
{
    var random = new Random();
    return random.Next(10, 51);
}

static int GetRandomPoderPiloto()
{
    var random = new Random();
    return random.Next(10, 101);
}