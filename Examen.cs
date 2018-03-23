using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Type> figuras = new List<Type>()
            {
            typeof(Estrella),
            typeof(Rayo),
            typeof(Corazon)
            };

            var color = new Dictionary<string, string>();
            color.Add("Rojo", "Rojo");
            color.Add("Blanco", "Blanco");
            color.Add("Negro", "Negro");
            color.Add("Amarillo", "Amarillo");

            if (null == color)
            {
                throw new Exception("El color no existe");
            }

            Console.WriteLine("Que figura quiero Dibujar" + figuras);
            Console.WriteLine("Color de Fondo:" + color);
            Console.WriteLine("Color de Borde:" + color);
            Console.ReadLine();
        }
    }
}
interface ILienzo { }


interface IToolbar
{
    void Container();
}

interface IContainer
{
    string Figura(List<Type> figuras);
    string Color();
    void Output();
}


interface IFigura
{
    string ColorFondo { get; set; }
    string ColorBorde { get; set; }

}



public class Figura
{
    public string ColorFondo;
    public string ColorRelleno;
}

public class Estrella : Figura
{

}
public class Rayo : Figura
{

}
public class Corazon : Figura
{

}
