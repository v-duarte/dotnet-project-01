using Biblioteca;

    // //Agregando un nuevo cliente
    // Cliente cli = new Cliente (
    //     20_000_000,
    //     "GOMEZ",
    //     "Andres",
    //     "Calle 13 N° 123",
    //     new DateTime(1968, 2, 24),
    //     DateTime.Today
    // );
    // new AgregarClienteUseCase().Ejecutar(cli);

//Agregando varios clientes
var agregarCliente = new AgregarClienteUseCase();
agregarCliente.Ejecutar(new Cliente (18_000_000, "COLOMBO", "Marina", "Calle 1 N° 1123", new DateTime(1960, 3, 14), new DateTime (2022, 4, 1)));
agregarCliente.Ejecutar(new Cliente (30_000_000, "MARTINEZ", "Jose", "Calle 12 N° 321", new DateTime(1980, 9, 12), new DateTime (2022, 1, 12)));
agregarCliente.Ejecutar(new Cliente (32_000_000, "GARCIA", "Analia", "Calle 13 N° 112", new DateTime(1982, 10, 29), DateTime.Today));
agregarCliente.Ejecutar(new Cliente (40_000_000, "FERRETI", "Josefina", "Diag. 74 N° 13", new DateTime(2000, 1, 17), new DateTime (2022, 4, 11)));

//Agregando un cliente que ya existe
Cliente cli = (new Cliente (30_000_000, "", "", "", new DateTime(), new DateTime ()));
try{
    new AgregarClienteUseCase().Ejecutar(cli);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

// //Modificando un cliente
//     Cliente cli = new Cliente (
//         30_000_000,
//         "MARTINEZ",
//         "Juan",
//         "Calle 12 N° 321",
//         new DateTime(1980, 9, 12),
//         new DateTime(2022, 1, 12)
//     );
//     new ModificarClienteUseCase().Ejecutar(cli);

// //Listando los clientes con la cantidad de dias desde su ultima compra
// var lista = new ListaDeClientesUseCase().Ejecutar();
// foreach(var cli in lista)
// {
//     Console.WriteLine($"{cli.Apellido}, {cli.Nombre}: {cli.diasDesdeUC} dias ");
// }

// //Eliminando el cliente GARCIA que tiene DNI 32_000_000
// new EliminarClienteUseCase().Ejecutar(32_000_000);

// //Eliminando un cliente que no existe
// try{
//     new EliminarClienteUseCase().Ejecutar(11_110_000);
// }
// catch (Exception e){
//     Console.WriteLine(e.Message);
// }

// //Listando todos los clientes
// //Observar como muestra los clientes el metodo Console.WriteLine
// var lista = new ListaDeClientesUseCase().Ejecutar();
// foreach(var cli in lista){
//     Console.WriteLine(cli);
// }

// // Agregando empleados 
// var agregarEmpleado = new AgregarEmpleadoUseCase();
// agregarEmpleado.Ejecutar(new Empleado(12_123_456, "SOSA", "Pablo", "Calle 5 N° 23", new DateTime(1950,11,17), 12));
// agregarEmpleado.Ejecutar(new Empleado(42_234_555, "RODRIGUEZ", "Juana", "Av. 7 N° 1223", new DateTime(2001,7,8), 301));
// agregarEmpleado.Ejecutar(new Empleado(43_015_771, "ALVAREZ", "Silvina", "Av. 25 N° 857", new DateTime(2002,10,22), 305));
// agregarEmpleado.Ejecutar(new Empleado(44_345_753, "ADAMI", "Julia", "Calle 53 N° 423", new DateTime(2002,2,22), 208));
// agregarEmpleado.Ejecutar(new Empleado(20_789_654, "MARTINEZ", "Daniel", "Calle 117 N° 54", new DateTime(1969,1,21), 101));

// //Listando todas las personas ordenadas por Apellido y Nombre
// var lista = new ListaDePersonasUseCase().Ejecutar();
// foreach(var persona in lista){
//     Console.WriteLine(persona);
// }
// Console.WriteLine("Presione una tecla para finalizar la aplicacion.");
// Console.ReadKey(true);