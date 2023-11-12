namespace Desafio {
    public class Integrador {

        public void Iniciar() {

            AbstractIntegracaoNotaFiscal integracaoAntena = new IntegradorAntena();
            integracaoAntena.Integrar(new NotaFiscal("12345", "A", 1001, NotaFiscal.ANTENA));

            AbstractIntegracaoNotaFiscal integracaoRecibo = new IntegradorRecibo();
            integracaoRecibo.Integrar(new NotaFiscal("67890", "R", 2001, NotaFiscal.RECIBO));

            AbstractIntegracaoNotaFiscal integracaoMensalidade = new IntegradorMensalidade();
            integracaoMensalidade.Integrar(new NotaFiscal("09876", "M", 1000, NotaFiscal.MENSALIDADE));

            AbstractIntegracaoNotaFiscal integracaoInscricao = new IntegradorInscricao();
            integracaoInscricao.Integrar(new NotaFiscal("54321", "I", 4000, NotaFiscal.INSCRICAO));

            AbstractIntegracaoNotaFiscal integracaoCheque = new IntegradorCheque();
            integracaoCheque.Integrar(new NotaFiscal("13579", "C", 2000, NotaFiscal.CHEQUE));

            AbstractIntegracaoNotaFiscal integracaoNotaPromissoria = new IntegradorNotaPromissoria();
            integracaoNotaPromissoria.Integrar(new NotaFiscal("24680", "NP", 4000, NotaFiscal.NOTA_PROMISSORIA));

            AbstractIntegracaoNotaFiscal integracaoFinanciamento = new IntegradorFinanciamento();
            integracaoFinanciamento.Integrar(new NotaFiscal("97531", "F", 7000, NotaFiscal.FINANCIAMENTO));

            AbstractIntegracaoNotaFiscal integracaoJudicial = new IntegradorJudicial();
            integracaoJudicial.Integrar(new NotaFiscal("08642", "J", 8000, NotaFiscal.JUDICIAL));

            AbstractIntegracaoNotaFiscal integracaoAdiantamento = new IntegradorAdiantamento();
            integracaoAdiantamento.Integrar(new NotaFiscal("11111", "AD", 9000, NotaFiscal.ADIANTAMENTO));

            AbstractIntegracaoNotaFiscal integracaoOutros = new IntegradorOutros();
            integracaoOutros.Integrar(new NotaFiscal("99999", "A", 25000, NotaFiscal.OUTROS));
        }
    }
}
