namespace CursoAlura02_OrientacaoObjetos {
    public class Titular {

        public static int TOTAL_CLIENTES;

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public Titular() {
            this.Nome = String.Empty;
            this.Cpf = String.Empty;
            this.Profissao = String.Empty;
            TOTAL_CLIENTES++;
        }

        public Titular(string nome) {
            this.Nome = nome;
            this.Cpf = String.Empty;
            this.Profissao = String.Empty;
            TOTAL_CLIENTES++;
        }
    }
}
