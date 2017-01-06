using aspnet_filemanager.Models;
using System.Web;

namespace aspnet_filemanager.Helpers
{
    /// <summary>
    /// Essa classe é responsável por manipular todas as sessions usadas no projeto.
    /// Qualquer nova Session inserida no sistema deve ser colocada nessa classe, criando um get, set e release especifico.
    /// </summary>
    public static class SessionManager
    {
        /// <summary>
        /// Método utilizado para pegar o usuário logado
        /// </summary>
        /// <returns></returns>
        public static User GetUser()
        {
            return HttpContext.Current.Session["userLoggedIn"] as User;
        }

        /// <summary>
        /// Método utilizado para setar um novo usuário 
        /// </summary>
        /// <param name="user"></param>
        public static void SetUser(User user)
        {
            HttpContext.Current.Session["userLoggedIn"] = user;
        }

        /// <summary>
        /// Método que remove a session do usuário quando ele faz um logoff
        /// </summary>
        public static void ReleaseUser()
        {
            HttpContext.Current.Session.Remove("userLoggedIn");
        }
    }
}