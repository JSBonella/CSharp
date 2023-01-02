public class Figura {

    public string Formato {get; set;}

    public string Cor {get; set;}

    public double Espessura {get; set;}

        public Figura(string formato, string cor, double espessura) {
            
            Formato = formato;
            Cor = cor;
            Espessura = espessura;
        }
}