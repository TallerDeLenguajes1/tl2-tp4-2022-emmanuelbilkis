namespace ServiciosdeCadetes
{
    class Persona
    {
        protected int id;
        protected string? nombre;
        protected string? direccion;
        protected string? telefono;

        public Persona(int idN, string nombreN, string direc, string tel)
        {
            id = idN;
            nombre = nombreN;
            direccion = direc;
            telefono = tel;
        }

        public string? getNombre()
        {
            return this.nombre;
        }

    }
}

