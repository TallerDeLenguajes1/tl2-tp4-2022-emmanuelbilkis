using ServiciosdeCadetes;

class Cliente : Persona
{
    private string? datosReferidosDireccion;
    public string? datosExtraDirec { get; }

    public Cliente(int id, string nombre, string direc, string tel, string datosExtrasDirec) : base(id, nombre, direc, tel)
    {

        datosReferidosDireccion = datosExtraDirec;
    }

}