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
        Console.Write("\n");
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
          Console.Write("\nIngrese ID de la tarea que realizo: ");
          do{
            id = ingresaEntero();
          }while(id==-999);
          TareasCompletadas.Add(manejadorDetareas.ObtenerTareaPorID(TareasPendientes,id));
          break;
        case 3:  
          if(TareasPendientes.Any()){ //Any devuelve True si hay al menos un elemento en la coleccion
            foreach(var tarea in TareasPendientes){
            tarea.MostrarTarea();
            Console.Write("\n");
            }
          } else{
            Console.WriteLine("No hay Tareas pendientes");
          }
          break;
        case 4: 
          if(TareasCompletadas.Any()){
            foreach(var tarea in TareasCompletadas){
            tarea.MostrarTarea();
            Console.Write("\n");
            }
          } else{
            Console.WriteLine("No hay Tareas completadas");
          }
          break;
        case 5: 
          Console.Write("\nIngrese el ID de la tarea a buscar: ");
          do{
            id = ingresaEntero();
          }while(id==-999);

          var tareaPendiente = manejadorDetareas.ObtenerTareaPorID(TareasPendientes, id);
          var tareaCompletada = manejadorDetareas.ObtenerTareaPorID(TareasCompletadas, id);

          if(tareaPendiente!=null){
            Console.WriteLine("\nLa tarea se encuentra Pendiente");
            tareaPendiente.MostrarTarea();
          }
          if( tareaCompletada!=null){
            Console.WriteLine("\nLa tarea se encuentra completada");
            tareaCompletada.MostrarTarea();
          }
          if(tareaPendiente==null && tareaCompletada==null){
            Console.WriteLine("\nNo se encontro la tarea de ID buscado");
          }
          break;
        case 6: 
          Console.WriteLine("\nPalabra clave para buscar tarea: ");
          palabra = Console.ReadLine();

          var tareaBuscada = manejadorDetareas.BuscarTareaPorPalabra(TareasPendientes, TareasCompletadas, palabra);

          if(tareaBuscada!=null){
            tareaBuscada.MostrarTarea();
          } else{
            Console.WriteLine("\nNo se encontro la tarea de ID buscado");
          }
          break;
        default:
          Console.WriteLine("\nSaliendo del programa...\n\n");
          return;
        }
  } while (opcion==1 || opcion==2 || opcion==3 || opcion==4 || opcion==5 || opcion==6);



//No remover en la iteracion porque no los dejara
//Buscar los archivos a remover y en otra iteracion removerlos?
//Podes usar breack al encontrar pero si no se lo hace y se sigue recorriendo se rompe

// //? es para decir que acepta nulo
// Tarea? tareaBuscada = BuscarTarea(tareasPendientes, "1")


enum EstadoTarea{
  Pendiente,
  EnCurso,
  Completado,
}


