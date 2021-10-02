using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;


namespace Ganaderia.App.Consola
{
    class Program
    {
        private static IRepositorioGanadero _repositorioGanadero = new RepositorioGanadero(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddGanadero();
        }

        private static void AddGanadero()
        {
         var ganadero = new Ganadero
         {
          Nombres = "Sergio",
          Apellidos = "Moreno",
          NumeroTelefono = "3045956788",
          Correo = "luismendoza3110@gmail.com",
          Contrasena = "123456",
          Latitude = 4554,
          Longitude = 5454
         };
          _repositorioGanadero.AddGanadero(ganadero);

        }
    }
}
