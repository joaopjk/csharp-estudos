using FluentAssertions;
using Rpg.Domain.Models.Dados;

namespace Rpg.Domain.Test.Models.Dados
{
    public class DadosTest
    {
        [Theory]
        [InlineData(TipoDeDado.D100)]
        [InlineData(TipoDeDado.D20)]
        [InlineData(TipoDeDado.D10)]
        [InlineData(TipoDeDado.D8)]
        [InlineData(TipoDeDado.D6)]
        [InlineData(TipoDeDado.D4)]
        public void VALIDAR_JOGAR_DADOS(TipoDeDado tipoDeDado)
        {
            var dado = DadosBuilder.CriarDado(tipoDeDado);

            var resultado = dado.LancarDado();

            resultado.Should().BeLessThanOrEqualTo((int)tipoDeDado);
            resultado.Should().BeGreaterThanOrEqualTo(dado.ValorMinimoDado);
        }
    }
}
