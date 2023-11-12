namespace CursoAlura03_HerancaInterfaces.Funcionarios {
    public class Funcionario {
        public static int TOTAL_FUNCIONARIOS { get; private set; }

        public string Nome { get; protected set; }
        public string Cpf { get; protected set; }
        public double Salario { get; protected set; }

        public Funcionario(string nome, string cpf, double salario) {
            TOTAL_FUNCIONARIOS++;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Salario = salario;
        }

        public virtual double GetBonificacao() {
            return this.Salario * 0.1;
        }
        public virtual void AumentarSalario() {
            this.Salario *= 1.1;
        }
    }
}
