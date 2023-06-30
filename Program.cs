using PresistenciaData;
internal class Program
{
    private static void Main(string[] args)
    {
            Controlador controller = new Controlador();
            bool isValid = false;
            int opcion = 0;
        do{
            Console.Clear();
            Console.WriteLine("1.Registro de equipos\n2.Editar Dato\n3. salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch(opcion){
                case 1:
                    Console.Clear();
                    controller.AddInfo();
                    break;
                case 2:
                    Console.WriteLine("")
                    break;
                default:
                    break;

            }
        }while(isValid);
    }
}