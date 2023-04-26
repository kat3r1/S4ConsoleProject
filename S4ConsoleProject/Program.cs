// See https://aka.ms/new-console-template for more information
using S4ConsoleProject;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");

string curso = "Desarrollo de ambiente web";
int edad = 22;
double salario = 2000;

var alumno = "Luis Chang";
var peso = 70;
var notaFinal = 18.50;

var persona1 = new Persona();
persona1.dni = 9922882;
persona1.telefono = "998399839";
persona1.nombreCompleto = "Paolo Guerrero";
persona1.estado = true;

var persona2 = new Persona()
{
    dni = 998888,
    telefono = "9898989865",
    nombreCompleto = "Gianluca Lapadula",
    estado = true
};

var persona3 = new Persona(182911, "Claudio Pizarro", "32323232", false);

var personas = new List<Persona>();
personas.Add(persona1);
personas.Add(persona2);
personas.Add(persona3);

//Lambda Expressions
var busqueda = personas.Where(x => x.dni == 9922882).FirstOrDefault();

//LINQ Query Expressions

//var busqueda2 = (from p in personas
//                where p.dni == 9922882
//                select p).FirstOrDefault();


if (busqueda != null)
    Console.WriteLine("La persona encontrada es: " + busqueda.nombreCompleto);
else
    Console.WriteLine("La persona no existe");


Console.ReadKey();


