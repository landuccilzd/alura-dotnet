namespace Desafio {
    public class IntegradorInscricao: AbstractIntegracaoNotaFiscal {

        public override bool VerificaNecessidadeIntegracao(NotaFiscal notaFiscal) {
            return (notaFiscal.ValorNota > 1000 && notaFiscal.ValorNota < 7000);
        }
    }
}
