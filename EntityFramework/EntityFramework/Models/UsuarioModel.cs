namespace EntityFramework.Models
{
    public class UsuarioModel
    {
        public int IdUsuario { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public string Perfil { get; set; }
    }
}
