namespace RepasoPC1.entities
{
    internal class Ruta
    {
        public Ruta(String codigo, String origen, String destino, Double kilometros) {
            Codigo = codigo;
            Origen = origen;
            Destino = destino;
            Kilometros = kilometros;
        }

        public String Codigo { get; set; }
        public String Origen { get; set; }
        public String Destino { get; set; }
        public Double Kilometros { get; set; }

        public String[] ConvertirArregloString()
        {
            String[] row = { Codigo, Origen, Destino, Kilometros.ToString() };
            return row;
        }
    }
}
