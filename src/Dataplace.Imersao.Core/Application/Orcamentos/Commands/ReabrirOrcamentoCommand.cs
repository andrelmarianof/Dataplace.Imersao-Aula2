using Dataplace.Core.Domain.Commands;

namespace Dataplace.Imersao.Core.Application.Orcamentos.Commands
{


    public class ReabrirOrcamentoCommand : Command
    {
        public int NumOcamento { get; set; }

        //verificar se o orçamento está como fechado
        //if (orçamento = fechado)
        //alterar orçamento para aberto
        // retornar verdadeiro para OrçamentoReabertoEvent 
        //else
        //Retornar falso para OrçamentoReabertoEvent
    }
}
