namespace tP4.Models
{
    public class Cadeteria
    {
        private string Nombre { get; set; }
        private string Direccion { get; set; }
        public List<Cadete> cadetes;

        public Cadeteria(string nombre, string direccion, List<Cadete> cadetes)
        {
            Nombre = nombre;
            Direccion = direccion;
            this.cadetes = cadetes;
        }

        public void MuestraCadetes()
        {
            foreach (var cadete in this.cadetes)
            {
                Console.WriteLine($"Nombre: {cadete.getNombre()}");
                Console.WriteLine($"Direccion: {cadete.getDireccion()}");
                Console.WriteLine($"ID: {cadete.getID()}");
                Console.WriteLine($"Telefono: {cadete.getTelefono()}");
                //Console.WriteLine($"Monto a cobrar: {cadete}");
                //Console.WriteLine($"Muestra pedidos a su cargo");
                //cadete.muestraPedidos();
            }
        }
    }
}
