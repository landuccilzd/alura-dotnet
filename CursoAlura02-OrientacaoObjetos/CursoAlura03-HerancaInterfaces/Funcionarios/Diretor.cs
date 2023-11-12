namespace CursoAlura03_HerancaInterfaces.Funcionarios {
    public class Diretor: Funcionario {

        public Diretor(string nome, string cpf, double salario) : base(nome, cpf, salario) { }

        public override double GetBonificacao() {
            return this.Salario + base.GetBonificacao();
        }

        public override void AumentarSalario() {
            this.Salario *= 1.15;
        }
    }
}
