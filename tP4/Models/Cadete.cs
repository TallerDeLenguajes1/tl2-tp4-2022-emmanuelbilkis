namespace tP4.Models
{
    public class Cadete
    {
        private string Nombre { get; set; }
        private string Direccion { get; set; }
        public int Telefono { get; set; }
        private int ID { get; set; }
        private float JornalCobrar { get; set; }
        private static int AutoIncremental;

        public Cadete(string nombre, string direccion, int telefono, int iD, float jornalCobrar)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            ID = iD;
            JornalCobrar = jornalCobrar;
        }

        //Metodos getter
        public string getNombre() { return this.Nombre; }
        public string getDireccion() { return this.Direccion; }
        public int getTelefono() { return this.Telefono; }
        public int getID() { return this.ID; }
    }


}
