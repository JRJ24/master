using System;
using System.Collections.Generic;

class Program{
    private static string[] titulos = new string[100];
    private static string[] autores = new string[100];
    private static int[] años = new int[100];
    private static int cantidadLibros = 0;

    private static int cantidadUsuarios = 1;

    // Estas listas es para ir guardando cada usuario que se registre y su contraseña
    private static List<string> User = new List<string>{"Jonaifry"};
    private static List<string>Password = new List<string>{"1234"};

    static void Main(){
        // El Administrador
        string ADMIN = "Bibli!@gmail.com";

        // Para conocer que el programa esta en uso
        bool prog = true;
        string resp, user, pass;

        // Comienza el programa
        while(prog){
            Console.WriteLine("Bienvenido a la Biblioteca");
            
            Console.WriteLine("Tienes una cuenta?");
            Console.WriteLine("\n 1) Inicio de Sesion");
            Console.WriteLine("\n 2) Registrarse");
            resp = Console.ReadLine()!;

            switch(resp){
                case "1":
                    Console.WriteLine("\n Inicio de Sesion");
                    Console.Write("\n Usuario: ");
                    user = Console.ReadLine()!;
                    Console.Write("\n Contraseña: ");
                    pass = Console.ReadLine()!;

                    // Verificamos si el usario y la contraseña son correctas.
                    for(int i = 0; i < User.Count(); i++){
                        if(user == User[i] && pass == Password[i]){
                            Console.WriteLine($"Bienvenido {user}");
                            Userr(user);
                            break;
                        }
                        // Verificamos si la cuenta ADMIN
                        else if(user == ADMIN){
                            Console.WriteLine($"Bienvenido Administrador {user}");
                            Admin();
                            break;
                        }

                        else if(i == User.Count){
                            Console.WriteLine("Tus credenciales estan erroneas");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }
                    }               
                break;

                // Registro de un nuevo Usuario
                case "2":
                    Console.WriteLine("\n Registro");
                    Console.Write("\n Usuario: ");
                    user = Console.ReadLine()!;
                    Console.Write("\n Contraseña: ");
                    pass = Console.ReadLine()!;

                    User.Add(user);
                    Password.Add(pass);
                    cantidadUsuarios++;
                break;

                default:
                    prog = !prog;
                break;
            }

        }
        
    }

    public static void Userr(string user){
        // Todo relacionado con el usuario
        bool UserProg = true;
        while(UserProg){
            Console.Clear();
            int resp;
            Console.WriteLine(user);
            Console.WriteLine("*****************************************");
            Console.WriteLine("*                                       *");
            Console.WriteLine("*                  Menu                 *");
            Console.WriteLine("*                                       *");
            Console.WriteLine("*    1) Catalogo 'Libros'               *");
            Console.WriteLine("*    2) Salir                           *");
            Console.WriteLine("*                                       *");
            Console.WriteLine("*****************************************");
            try{
                do{
                    resp = Convert.ToInt32(Console.ReadLine()!);
                }while(resp > 2);

                if(resp == 1){
                    // Llameremos a la funcion catalogo en donde se haran las opciones como Alquilar un libro o devolverlo.
                    // Catalogo();
                }
                else{
                    UserProg = !UserProg;
                }
            }catch(Exception e){
                Console.WriteLine(e);
            }

        }
    }

    public static void Admin(){
        bool AdminProg = true;
        while(AdminProg){
            Console.Clear();
            int opcion;
            Console.WriteLine("*********************************************************");
            Console.WriteLine("*           Sistema de Gestión de Librería              *");
            Console.WriteLine("*    1. Añadir Libro                                    *");
            Console.WriteLine("*    2. Listar Libros                                   *");
            // Console.WriteLine("*    3. Añadir Usuario                                  *");
            Console.WriteLine("*    4. Listar Usuarios                                 *");
            Console.WriteLine("*    0. Salir                                           *");
            Console.WriteLine("*********************************************************");
            Console.Write("\nIngrese su opción: ");
            do{
                opcion = int.Parse(Console.ReadLine()!);
                switch (opcion)
                {
                    case 1:
                        AnadirLibro();
                        break;
                    case 2:
                        ListarLibros();
                        break;
                    /*case 3:
                        // AnadirUsuario();
                        break; */
                    case 4:
                        ListarUsuarios(User);
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        Thread.Sleep(2000);
                        AdminProg = !AdminProg;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente nuevamente.");
                        break;
                }
            }while(opcion > 4);

        }
    }

    // Anda vacio, esto seria para el usuario
    public static void Catalogo(){

    }

    // Función para añadir un libro
    public static(int [], string[], string[]) AnadirLibro()
    {
        if (cantidadLibros < titulos.Length)
        {
            Console.Write("Ingrese el Título del Libro: ");
            titulos[cantidadLibros] = Console.ReadLine()!;
            Console.Write("Ingrese el Autor del Libro: ");
            autores[cantidadLibros] = Console.ReadLine()!;
            Console.Write("Ingrese el Año del Libro: ");
            años[cantidadLibros] = int.Parse(Console.ReadLine()!);
            cantidadLibros++;
            Console.WriteLine("Libro añadido exitosamente.");
        }
        else
        {
            Console.WriteLine("La estanteria de libros está lleno.");
        }

        return(años, titulos, autores);
    }

    // Función para listar todos los libros
    public static void ListarLibros()
    {
        if (cantidadLibros == 0)
        {
            Console.WriteLine("No hay libros disponibles.");
            // Cual es la funcion de este Return
            return;
        }

        Console.WriteLine("Lista de Libros:");
        for (int i = 0; i < cantidadLibros; i++)
        {
            Console.WriteLine($"Título: {titulos[i]}, Autor: {autores[i]}, Año: {años[i]}");
        }
    }

   // Mostrar los usuarios, solo faltaria agregarle que libro alquilo.
    public static List<string> ListarUsuarios(List<string> user)
    {
        if (cantidadUsuarios == 0)
        {
            Console.WriteLine("No hay usuarios disponibles.");
            return user;
        }

        Console.WriteLine("Lista de Usuarios:");
        for (int i = 0; i < cantidadUsuarios; i++)
        {
            Console.WriteLine($"Nombre: {user[i]}");
        }

        return user;
    }
}


