namespace TiendaApi.Conexion
{
    public class ConexionBD
    {
        private string connectionString = string.Empty; //con empty limpio la cadena para que este vacio

        public ConexionBD() 
        {
            var constructor = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            /* ConfigurationBuilder indica que es la construccion del constructor Build indica construir y acabamos de acceder al directorio appSetting
             * dond e esta nuestra cadena */

            connectionString = constructor.GetSection("ConnectionStrings:conexionmaestra").Value;
            /*con nuestra variable conectionstring accedemos a laa seccion de nuestro directorio y nos traremos la cadena de conexion*/
        }
        public string getConection()
        {
            return connectionString;
        }
    }
}
