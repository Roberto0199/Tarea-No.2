//Este es el primer ejercicio
/*byte age;

Console.Write("¿Cuál es tu edad? ");
age= Convert.ToByte(Console.ReadLine());

Console.WriteLine("No aparenta que tengas {0} años.", age);*/

//Este es el segundo ejercicio 
/*byte Num1;
byte Num2;
ushort Result;
Console.Write("Ingrese su primer numero de dos cifras:");
Num1= Convert.ToByte(Console.ReadLine());

Console.Write("Ingrese su segundo numero igualemte de dos cifras:");
Num2= Convert.ToByte(Console.ReadLine());   
Result=(ushort)(Num1*Num2);

Console.WriteLine("El resultado de la multiplicacion es: {0}", Result);*/

//Este es el tercer ejercicio 
long Num1;
long Num2;
long suma;
long Resta;
long Mult;
Console.Write("Ingrese su primer numero:");
Num1 = long.Parse(Console.ReadLine());
Console.Write("Ingrese su segundo numero:");
Num2 = long.Parse(Console.ReadLine());

suma = Num1 + Num2;
Console.WriteLine("El resultado de su suma es:{0}", suma);

Resta = Num1 - Num2;
Console.WriteLine("El resultado de su resta es:{0}", Resta);

Mult = Num1 * Num2;
Console.WriteLine("El resultado de su multiplicacion es:{0}", Mult);



