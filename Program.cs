using EspacioTareas;

// int ID=1;
// string descripcion="tarea1";
// int duracion =10;
// Tareas tarea1 = new Tareas(1, "T1", duracion);
// Tareas tarea2 = new Tareas(2, "T2", duracion);
// Tareas tarea3 = new Tareas(3, "T3", duracion);
//lista generica, dentro de <> le digo que tendra los nodos de la lista
// List<Tareas> tareas = new List<Tareas>();
// tareas.Add(tarea1);
// tareas.Add(tarea2);
// tareas.Add(tarea3);
// tarea1.MostrarTarea();

List <Tarea> TareasPendientes =new List <Tarea>();
List <Tarea> TareasCompletadas =new List <Tarea>();
int cantidadPendiente =10;
// int cantidadCompletada =10;
 
TareasPendientes = CrearTareas(cantidadPendiente);
// TareasCompletadas = CrearTareas(cantidadCompletada);

//Muestra todas las tareas
foreach(var tarea in TareasPendientes){
  tarea.MostrarTarea();
}


//No remover en la iteracion porque no los dejara
//Buscar los archivos a remover y en otra iteracion removerlos?
//Podes usar breack al encontrar pero si no se lo hace y se sigue recorriendo se rompe

//encapsular el sistema de crear tareas y despues asignarlos a la lista
List<Tarea> CrearTareas(int cantidad)
{
    List <Tarea> tareas = new List<Tarea>();
    for (int i = 0; i < cantidad; i++)
    {
        //id ingresado
        //duracion aleatorio
        //descripcion a ingresar
        Tarea tarea = new Tarea(i, $"decirHola {i}", i + 1);
        tareas.Add(tarea);
    }
    return tareas;
}


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
