namespace ServiciosdeCadetes
{
    internal class Pedido
    {
        private int numero;
        private string? observaciones;
        private string? estado;
        private Cliente? cliente;
        private string? cadete;
        private float precio;

        public Pedido(int num, string obs, string est, Cliente client, float precio)
        {
            this.numero = num;
            this.observaciones = obs;
            this.cliente = client;
            this.estado = est;
            this.precio = precio;
        }

        public void asignarCadete(Cadete cadete) => this.cadete = cadete.getNombre();

        public void cambiarCadete(Cadete cadete)
        {
            if (this.estado != "Enviado")
            {
                this.asignarCadete(cadete);
            }
            else
            {
                Console.WriteLine("El pedido ya esta en camino, no se puede asignar un nuevo cadete");
            }

        }

        public void cambiarEstado(string nuevoEstado)
        {
            this.estado = nuevoEstado;
        }


        public float getPrecio()
        {
            return this.precio;
        }

        public void mostrarCadete()
        {
            Console.WriteLine($"El cadete es: {this.cadete}");
        }

    }
}
