namespace Desafio {
    public abstract class AbstractIntegracaoNotaFiscal: IIntegracaoNotaFiscal {

        public void Integrar(NotaFiscal notaFiscal) {
            if (VerificaNecessidadeIntegracao(notaFiscal)) {
                Console.WriteLine($"Integrando nota: {notaFiscal}");
            }
        }

        public abstract bool VerificaNecessidadeIntegracao(NotaFiscal notaFiscal);
    }
}
