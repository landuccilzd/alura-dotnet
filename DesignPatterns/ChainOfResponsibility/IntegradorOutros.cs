namespace Desafio {
    public class IntegradorOutros: AbstractIntegracaoNotaFiscal {
        public override bool VerificaNecessidadeIntegracao(NotaFiscal notaFiscal) {
            return (notaFiscal.ValorNota > 10000 && "A".Equals(notaFiscal.SerieNota));
        }
    }
}
