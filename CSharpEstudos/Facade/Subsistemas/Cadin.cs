﻿namespace Facade.Subsistemas
{
    internal class Cadin
    {
        public bool EstaNoCadin(Cliente cliente)
        {
            Console.WriteLine("Verificando CADIN do cliente " + cliente.Nome);
            return false;
        }
    }
}
