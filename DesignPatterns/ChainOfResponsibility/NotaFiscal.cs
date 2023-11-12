namespace Desafio {
    public class NotaFiscal {

        public static readonly int ANTENA = 1;
        public static readonly int RECIBO = 2;
        public static readonly int MENSALIDADE = 3;
        public static readonly int INSCRICAO = 4;
        public static readonly int CHEQUE = 5;
        public static readonly int NOTA_PROMISSORIA = 6;
        public static readonly int FINANCIAMENTO = 7;
        public static readonly int JUDICIAL = 8;
        public static readonly int ADIANTAMENTO = 9;
        public static readonly int OUTROS = 10;

        private readonly string[] _TipoNotaExtenso = new string[] {
            "Antena",
            "Recibo",
            "Mensalidade",
            "Inscricao",
            "Cheque",
            "Nota Promissória",
            "Financiamento",
            "Judicial",
            "Adiantamento",
            "Outros"
        };

        public string NumeroNota { get; set; } = string.Empty;

        public string SerieNota { get; set; } = string.Empty;

        public double ValorNota { get; set; }

        public int TipoNota { get; set; }

        public NotaFiscal(string numero, string serie, double valor, int tipo) {
            this.NumeroNota = numero;
            this.SerieNota = serie;
            this.ValorNota = valor;
            this.TipoNota = tipo;
        }

        public override string ToString() {
            return $"NF: {NumeroNota}/{SerieNota} - Valor: {ValorNota} - Tipo: {(TipoNota > 0 ? _TipoNotaExtenso[TipoNota - 1] : "")}";
        }
    }
}
