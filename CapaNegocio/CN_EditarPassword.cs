using CapaDatos;

namespace CapaNegocio
{
    public class CN_EditarPassword
    {
        CD_EditarPassword usuario = new CD_EditarPassword();
        public void EditarPassword(string hasheo2, string username)
        {
            usuario.EditarPassword(hasheo2, username);
        }
    }
}
