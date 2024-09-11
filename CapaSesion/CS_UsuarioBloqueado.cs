namespace CapaSesion
{
    public class CS_UsuarioBloqueado
    {
        public bool Bloqueado { get; set; }
        public int BloqueadoHasta { get; set; }
        public bool UsuarioTemporal { get; set; }
        public int VenceUsuario { get; set; }
        public int VencenPermisos { get; set; }
    }
}
