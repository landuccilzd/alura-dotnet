namespace CursoAlura02_OrientacaoObjetos {
    internal class ContaCorrente {

        public int Agencia { get; set; }
        
        public Titular Titular { get; set; }

        private string _numero;
        public string Numero { 
            get { return this._numero; }
            set { 
                if (String.Empty.Equals(value)) {
                    return;
                }

                this._numero = value;
            }
        }


        private double _saldo;
        public double Saldo { 
            get { return this._saldo; }
            set {
                if (value < 0) {
                    return;
                }

                this._saldo = value;
            }
        }

        public ContaCorrente() {
            this.Agencia = 0;
            this.Titular = new();
            this._numero = String.Empty;
            this._saldo = 0;
        }
        
        public ContaCorrente(int agencia, string numero, string titular, double saldo) {
            this.Agencia = agencia;
            this.Titular = new Titular(titular);
            this._numero = String.Empty;
            this._saldo = saldo;
        }

        public void Depositar(double valor) {
            this.Saldo += valor;
        }

        public bool Sacar(double valor) {
            if (valor > this.Saldo) {
                return false;
            }

            this.Saldo -= valor;
            return true;
        }

        public bool Transferir(double valor, ContaCorrente destino) {
            if (!this.Sacar(valor)) {
                return false;
            }

            destino.Depositar(valor);
            return true;
        }

    }
}
