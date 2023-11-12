namespace Desafio {
    internal class IntegradorNotaPromissoria: AbstractIntegracaoNotaFiscal {
        public override bool VerificaNecessidadeIntegracao(NotaFiscal notaFiscal) {
            return (notaFiscal.ValorNota > 3000 && notaFiscal.ValorNota < 5000);
        }
    }
}
