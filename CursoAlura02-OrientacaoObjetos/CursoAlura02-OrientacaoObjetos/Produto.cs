namespace CursoAlura02_OrientacaoObjetos {
    internal class Produto {
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public string CodigoBarras { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorCompra { get; set; }
        public int Quantidade { get; set; }

        public Produto() {
            this.Nome = "";
            this.Fabricante = "";
            this.CodigoBarras = "";
            this.ValorUnitario = 0d;
            this.ValorCompra = 0d;
            this.Quantidade = 0;
        }

        public Produto(string nome, string fabricante, string codigoBarras) {
            this.Nome = nome;
            this.Fabricante = fabricante;
            this.CodigoBarras = codigoBarras;
            this.ValorUnitario = 0;
            this.ValorCompra = 0;
            this.Quantidade = 0;
        }
    }
}
