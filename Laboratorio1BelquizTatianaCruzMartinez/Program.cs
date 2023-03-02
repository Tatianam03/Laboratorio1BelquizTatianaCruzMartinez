using Laboratorio1BelquizTatianaCruzMartinez.Entidades;
using Laboratorio1BelquizTatianaCruzMartinez.Negocio;

Persona persona = new Persona();
ClsPersona clsPersona = new ClsPersona();

Console.WriteLine("Ingrese su nombre");
persona.Nombre = Console.ReadLine();

Console.WriteLine("Ingrese su edad");
persona.Edad = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa su sexo");
persona.Sexo = Console.ReadLine();

Console.WriteLine("Ingrese su peso");
persona.Peso = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su altura");
persona.Altura = double.Parse(Console.ReadLine());


clsPersona.calcularIMC(persona);
clsPersona.esMayorDeEdad(persona);
