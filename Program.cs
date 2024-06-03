using EspacioTareas;

int ingresaEntero(){
  int num;
  if(int.TryParse(Console.ReadLine(), out num)){
    return num;
  } else{
    return -999;
  }
}

//Para usar creacion de tareas primero la instanciare
ManejadorDetareas manejadorDetareas = new();
List <Tarea> TareasPendientes =new List <Tarea>();
List <Tarea> TareasCompletadas =new List <Tarea>();
int opcion, cantidad, id;
string palabra;

 do
  {
        Console.WriteLine("\n\n*****     MENU ADMINISTRADOR DE TAREAS     ****");
        Console.WriteLine("\nSeleccione una opcion");
        Console.WriteLine("\t1. Cargar taras pendientes");              
        Console.WriteLine("\t2. Cambiar tarea de pendiente a realizada");  
        Console.WriteLine("\t3. Mostrar tareas pendientes");               
        Console.WriteLine("\t4. Mostrar tareas realizadas");               
        Console.WriteLine("\t5. Buscar tarea por ID");                     
        Console.WriteLine("\t6. Buscar tarea por palabra");
        Console.WriteLine("\tSalir -> Presione cualquier otra tecla");
        Console.Write("Operacion elegida: ");
        opcion = ingresaEntero();
        switch (opcion)
        {
        case 1: 
          Console.Write("\nCantidad de tareas pendientes que desea cargar: ");
          do{
            cantidad = ingresaEntero();
          }while(cantidad==-999);

          TareasPendientes = manejadorDetareas.CrearTareas(cantidad);
          break;
        case 2: 
          Console.WriteLine("\nIngrese ID de la tarea que realizo: ");
          do{
            id = ingresaEntero();
          }while(id==-999);
          break;
        case 3:  
          foreach(var tarea in TareasPendientes){
            tarea.MostrarTarea();
          }
          break;
        case 4: 
          foreach(var tarea in TareasCompletadas){
            tarea.MostrarTarea();
            Console.Write("\n");
          }          
          break;
        case 5: 
          Console.WriteLine("\nIngrese el ID de la tarea a buscar: ");
          do{
            id = ingresaEntero();
          }while(id==-999);
          break;
        case 6: 
          Console.WriteLine("\nPalabra clave para buscar tarea: ");
          palabra = Console.ReadLine();
          // buscarPorPalabra(listaTareasPendientes, listaTareasRealizadas, palabra);
          break;
        default:
          Console.WriteLine("\nSaliendo del programa...\n\n");
          return;
        }
  } while (opcion==1 || opcion==2 || opcion==3 || opcion==4 || opcion==5 || opcion==6);



//No remover en la iteracion porque no los dejara
//Buscar los archivos a remover y en otra iteracion removerlos?
//Podes usar breack al encontrar pero si no se lo hace y se sigue recorriendo se rompe

//encapsular el sistema de crear tareas y despues asignarlos a la lista
// List<Tarea> CrearTareas(int cantidad)
// {
//     List <Tarea> tareas = new List<Tarea>();
//     for (int i = 0; i < cantidad; i++)
//     {
//         //id ingresado
//         //duracion aleatorio
//         //descripcion a ingresar
//         Tarea tarea = new Tarea(i, $"decirHola {i}", i + 1);
//         tareas.Add(tarea);
//     }
//     return tareas;
// }
// //Creao lista de tareas pendientes y completadas
// Tareas tareaP = tareaPendiente[0]
// tareaP.Estado1 = EstadoTarea.Completado;
// TareasCompletadas.Add(tareaP)
// tareaPendiente.Remove(tareaP)
// Tarea BuscarTarea(List<Tareas> tareas, string descripcion){
//   foreach (var tarea in tareas)
//   {
//     if(tarea.Descripcion.Constains(descripcion))
//   return tarea;
//   }
//   return null;
// }

// //? es para decir que acepta nulo
// Tarea? tareaBuscada = BuscarTarea(tareasPendientes, "1")

// if(tareaBuscada!=null) System.console.writeline(tareaBuscada.descripcion)


enum EstadoTarea{
  Pendiente,
  EnCurso,
  Completado,
}


