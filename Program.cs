//Pastrana Garnica Anael Alejandro 
//226Z0188
//13-02-2024

double grado;
double grado2;
double radian;
double radian2;
int op;

Console.WriteLine("¿Que deseas obtener?");
Console.WriteLine("\n1.- Grados \n2.- Radianes");
op = int.Parse(Console.ReadLine());


switch (op)
{
    case 1:

        Console.WriteLine("Dame los grados");
        grado = int.Parse(Console.ReadLine());
        radian = grado * Math.PI / 180;
        Console.WriteLine("El resultado de la conversion es: " + radian + " Radianes");
        break;

    case 2:
        Console.WriteLine("Dame los radianes");
        radian2 = double.Parse(Console.ReadLine());
        grado2 = radian2 * 180 / Math.PI;
        Console.WriteLine("El resultado de la conversion es: " + grado2 + " Grados");
        break;
}