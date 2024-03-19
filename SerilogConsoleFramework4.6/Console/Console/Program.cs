using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.File(@"C:\\Users\\Propietario\\Desktop\\SerilogConsoleFramework4.6\\Console\\Console\\Logger\\Log.txt").CreateLogger();

            Log.Information("Este es un log de prueba de Consola con Net Framework 4.6");

            try 
            {
                int a = 2;
                int b = 0;
                Log.Warning("Los valores son {0} and {1}", a, b);
                int c = a / b;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Ocurrio un error");
            }

            Log.CloseAndFlush();

            //Console.WriteLine("Completado");
            //Console.ReadKey();

        }
    }
}
