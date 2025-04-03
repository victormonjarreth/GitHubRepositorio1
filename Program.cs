<<<<<<< HEAD
﻿//programa que permita visualizar los departamentos de nicaragua con
//su cantidad poblacional.
//Encuentre: Mayor, menor, sumas y ordene los datos
using System.Collections;
Dictionary<string, int> dep = new()
{
    {"Boaco",185013},
    {"Carazo",197139},
    {"Chinandega",439906},
    {"Chontales",190863},
    {"Costa Caribe Norte",530586},
    {"Costa Caribe Sur",414543},
    {"Estelí",229866},
    {"Granada",214317},
    {"Jinotega",475630},
    {"León",421050},
    {"Madriz",174744},
    {"Managua",1546939},
    {"Masaya",391903},
    {"Matagalpa",593503},
    {"Nueva Segovia",271581},
    {"Río San Juan",135446},
    {"Rivas",182645}
};
//Ordenando con diccionario y Orderby de LINQ
var orderDepResult = dep.OrderBy(d => d.Value);
//Encontrar el menor
var menDep = dep.Select(d => d).Where(d => d.Value == dep.Values.ToArray().Min());
//Encontrar el departamento con mayor población
Console.WriteLine("Departamento con menor Población:");

foreach (var order in menDep)
    Console.WriteLine($"{order.Key,20} ==> {order.Value,10:N0}");

Console.WriteLine("Departamento con mayor Población:");
foreach (var item in orderDepResult)
    Console.WriteLine($"{item.Key,20} ==> {item.Value,10:N0}");
    //Sumar todas las poblaciones con LINQ
int total = orderDepResult.ToDictionary(kvp => kvp.Key, kvp => kvp.Value).Values.ToArray().Sum();

Console.WriteLine($"Población General:{total,17:N0}");
//mostrar los tres departamentos con mayor población
var tresMayores = orderDepResult.TakeLast(3);
Console.WriteLine($"Los tres departemento con mayor población son:");
tresMayores = tresMayores.OrderByDescending(d => d.Value);
foreach (var item in tresMayores)
    Console.WriteLine($"{item.Key}");
=======
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
>>>>>>> VersionSimple
