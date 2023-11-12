using CursoAlura03_HerancaInterfaces.Funcionarios;

namespace CursoAlura03_HerancaInterfaces.Util {
    public class GerenciadorBonificacao {

        public double TotalBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario) {
            this.TotalBonificacao += funcionario.GetBonificacao();
        }
    }
}
