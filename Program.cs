﻿using System.Collections;
//defincion e inicialización de los arreglos en paralelo y el diccionario
String[] Departamento = {"Boaco","Carazo","Chinandega","Chontales","Costa Caribe Norte","Costa Caribe Sur","Estelf","Granada","Jinotega","León","Madriz","Managua","Masaya","Matagalpa","Nueva Segovia","Rio San、Juan","Rivas"}; 
int[] Poblacion = { 185013, 197139, 439906, 190863, 530586, 414543, 229866, 214317, 475630, 421050, 174744, 1546939, 391903, 593503, 271581, 135446, 182645};
Dictionary<string, int> diccionario = Departamento
.Zip(Poblacion, (k, v)=> new {Clave = k, Valor = v})
.ToDictionary (x => x.Clave, x => x.Valor);
//Ordenando el diccionario de menor a mayor
var ordenado = diccionario.OrderBy (x => x.Value).ToDictionary (x => x.Key, x => x.Value);
//fijando los nombres de los departamen tos con menor y mayor poblacion
string minDepkey = ordenado. First () .Key;
string maxDepkey= ordenado. Last ().Key;
 //reasignación de los arreglos en paralelo 
Departamento = ordenado.Keys.ToArray ();
Poblacion = ordenado.Values.ToArray ();
//Mostrar los arreglos ordenados de menor a mayor.
for (var i= 0; i< Poblacion. Length; i++)
Console.WriteLine ($"{Departamento [i],20} ==> {Poblacion [i],10:N0}");
 //Suma de toda la población y nombre de mayor y menor 
Console.WriteLine ($" Población General:{Poblacion. Sum():N0}");
Console.WriteLine ($"Departamento con mayor Población:{maxDepkey}");
Console.WriteLine ($"Departamento con menor Población:{minDepkey}");
