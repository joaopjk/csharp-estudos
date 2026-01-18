using FluentAssertions;
using Rpg.Domain.Models.Heroi.VOs;

namespace Rpg.Domain.Test.Models.VOs
{
    public class DestrezaTest
    {
        [Theory]
        [InlineData(Constantes.ATRIBUTO_VALOR_MAXIMO)]
        [InlineData(Constantes.ATRIBUTO_VALOR_MINIMO)]
        public void E_POSSIVEL_CRIAR_ATRIBUTO(int valor)
        {
            var atributo = new Destreza(valor);

            atributo.Should().NotBeNull();
            atributo.Valor.Should().Be(valor);
        }

        [Theory]
        [InlineData(Constantes.ATRIBUTO_VALOR_MAXIMO + 1)]
        [InlineData(Constantes.ATRIBUTO_VALOR_MINIMO - 1)]
        public void NAO_E_POSSIVEL_CRIAR_ATRIBUTO(int valor)
        {
            Action act = () => { var atributo = new Destreza(valor); };

            act.Should().Throw<ArgumentOutOfRangeException>();
        }
    }
}
