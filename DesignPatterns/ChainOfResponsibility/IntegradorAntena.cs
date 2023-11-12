namespace Desafio {
    public class IntegradorAntena: AbstractIntegracaoNotaFiscal {

        public override bool VerificaNecessidadeIntegracao(NotaFiscal notaFiscal) {
            return (notaFiscal.ValorNota > 1000);
        }
    }
}
