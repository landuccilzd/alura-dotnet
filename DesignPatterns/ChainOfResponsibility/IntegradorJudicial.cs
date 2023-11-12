namespace Desafio {
    public class IntegradorJudicial: AbstractIntegracaoNotaFiscal {

        public override bool VerificaNecessidadeIntegracao(NotaFiscal notaFiscal) {
            return (notaFiscal.ValorNota > 4000);
        }
    }
}
