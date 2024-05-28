namespace EspacioTareas;

//publica para que sea accesible para todo el proyecto
public class Tarea{

  //Si no estan seteados me da error, consultar
  //Los datos son privados por defecto
  private int tareaID;
  private string descripcion;
  private int duracion;
  //puedo estraer como campos y atemas crear un constructor

//Propiedades con acceso
//Las uso para acceder a los datos que son privados, con esto mantengo el encapsulamiento
    public int TareaID { get => tareaID; set => tareaID = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }

//Constructor
    public Tarea(int tareaID, string descripcion, int duracion){
        TareaID = tareaID;
        Descripcion = descripcion;
        Duracion = duracion;
    }

//Metodo para mostrar las tareas
    public void MostrarTarea(){
      Console.WriteLine("ID de la tarea: "+TareaID);
      Console.WriteLine("Descripcion de la tarea: "+Descripcion);
      Console.WriteLine("Duracion de la tarea: "+Duracion);
    }
}

// public class CrearTareas
// {
//     public CrearTareas()
//     {
//     }
// }