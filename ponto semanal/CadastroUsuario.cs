using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponto_semanal
{
    static class CadastroUsuario
    {
        private static Usuario[] usuarios =
        {
            new Usuario(){Name = "Diego", Senha = "123456a" },
            new Usuario(){Name = "Lucas", Senha = " 123456o"},
            new Usuario(){Name = "Vitoria", Senha = null},
        };

        private static Usuario _userLogado = null;

        public static Usuario UserLogado
        {
            get { return _userLogado; }
            private set { _userLogado = value; }
        }
        public static bool login(string nome, string senha)
        {
            foreach(Usuario usuario in usuarios)
            {
                if(usuario.Name == nome && usuario.Senha == senha )
                {
                    UserLogado = usuario;
                    return true;
                }
            }

            return false;
        }
    }
}
