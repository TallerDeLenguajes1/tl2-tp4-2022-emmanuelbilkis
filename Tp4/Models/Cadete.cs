using System;

namespace ServiciosdeCadetes
{
    class Cadete : Persona
    {
        List<Pedido> pedidos;

        public Cadete(int idN, string nombreN, string direc, string tel) : base(idN, nombreN, direc, tel)
        {
            this.pedidos = NULL;
        }

        public float jornalACobrar()
        {
            return 300 * this.pedidos.Count();
        }

        public void asignar(Cadete cadete)
        {
            foreach (var pedido in pedidos)
            {
                pedido.asignarCadete(cadete);
            }
        }

    }
}



