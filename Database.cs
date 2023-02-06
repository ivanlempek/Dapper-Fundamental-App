using Microsoft.Data.SqlClient;

namespace Blog
{
    // Aqui nós vamos apenas criar uma classe que vai possuir a nossa conexão com o banco de dados
    // Vamos usar essa classe nos outros arquivos para criar a conexão de uma forma mais fácil
    public static class Database
    {
        public static SqlConnection Connection;
    }
}