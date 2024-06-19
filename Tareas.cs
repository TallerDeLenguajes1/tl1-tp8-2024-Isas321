namespace EspacioTareas;
//publica para que sea accesible para todo el proyecto
public class Tarea{
  //Si no estan seteados me da error, consultar
  //Los datos son privados por defecto
  private int tareaID;
  private string descripcion;
  private int duracion;
  //puedo extraer como campos y ademas crear un constructor, usar el ffoco de visual studio code

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

public class ManejadorDetareas{
  public int duracion;
  public string descripcion;
  public List<Tarea> CrearTareas(int cantidad)
  {
      List <Tarea> tareas = new List<Tarea>();
      Random random = new Random();

      for (int i = 0; i < cantidad; i++)
      {
          Console.Write($"Descripcion de la tarea de ID[{i+1}]: ");
          descripcion = Console.ReadLine();
          duracion = random.Next(1,101);
          Tarea tarea = new Tarea(i+1, descripcion , duracion);
          tareas.Add(tarea);
      }
      return tareas;
  }

  public Tarea ObtenerTareaPorID(List<Tarea> tareas, int ID){
    foreach (Tarea tarea in tareas)
    {
      if(tarea.TareaID==ID){
        return tarea;
      } 
    }
    return null;
  }

  public Tarea BuscarTareaPorPalabra(List<Tarea> tareasPendientes, List<Tarea> tareasCompletadas, string palabra){
    foreach (var tarea in tareasPendientes)
    {
      if(tarea.Descripcion.Contains(palabra)){
        return tarea;
      }
    }
        foreach (var tarea in tareasCompletadas)
    {
      if(tarea.Descripcion.Contains(palabra)){
        return tarea;
      }
    }
    return null;
  }
}