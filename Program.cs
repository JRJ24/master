using System;
using System.Collections.Generic;

class Program
{
    private static string[] titulos = new string[20]
    {
        "El principito",                        
        "Don Quijote de la Mancha", 
        "Cien años de soledad", "1984",
        "El señor de los anillos", 
        "Crimen y castigo", 
        "Harry Potter y la piedra filosofal",
        "La Odisea", 
        "Alicia en el país de las maravillas", 
        "Matar a un ruiseñor",
        "Orgullo y prejuicio", 
        "El gran Gatsby",
        "Los miserables", "Guerra y paz",
        "Ulises",
        "En busca del tiempo perdido",
        "El guardián entre el centeno",
        "La divina comedia",
        "Moby Dick",
         "Cumbres borrascosas"
    };

    private static string[] autores = new string[20]
    {
        "Antoine de Saint-Exupéry",
        "Miguel de Cervantes",
        "Gabriel García Márquez",
        "George Orwell",
        "J.R.R. Tolkien",
        "Fyodor Dostoyevsky",
        "J.K. Rowling",
        "Homero",
        "Lewis Carroll",
        "Harper Lee",
        "Jane Austen",
        "F. Scott Fitzgerald",
        "Victor Hugo",
        "Leo Tolstoy",
        "James Joyce",
        "Marcel Proust",
        "J.D. Salinger",
        "Dante Alighieri",
        "Herman Melville",
        "Emily Brontë"
    };

    private static int[] años = new int[20]
    {
        1943,
        1605,
        1967,
        1949,
        1955,
        1866,
        1997,
        -800,
        1865,
        1960,         
        1813,
        1925,
        1862,
        1869,
        1922,
        1913,
        1951,
        1320, 
        1851, 
        1980,
    };

    private static int cantidadLibros = 20;
    private static int cantidadUsuarios = 3;

    // Listas para guardar usuarios y contraseñas
    private static List<string> User = new List<string> { 
        "Jonaifry", 
        "Gary",
        "Orison",
        };
    private static List<string> Password = new List<string> { 
        "1234",
        "1233",
        "1244"
        };

    static void Main()
    {
                /*Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWWWNNNNNNNNWNNNNNWWWWWMWWNXKKNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
                Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWNNNKkdox0XXXNNNNNNNNWWNNXXKKXNWWWWWWWWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
                Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWWNKdcclll,,x0KK0XNNNNXKKKKKXKKXNNNNWWWWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
                Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWWMMMMMMMMMMMMWWWWWN0kOKNNWk.lNO;.oXNNKl;,:OXXKXNNx:OWNWWWMMMMMMMMMMMMMMMMMMMMWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
                Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWNXXXXNWWMMMMWMMMWWNNNNNNXKKKXWd.ok:c,'OXd:okc.cXXXXNWK0XNNWWMMMMMMMMMMMMMMMMMMWNXXXNNWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
                Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMWWWNXXKKKKKKKKXXNWWWWMMMMWWNXXXXXKXXX0;'::kK;'d::ONW0',0NXNXkOXNNNWWMMMMMMMMMMMMMMMWNXXKKKKKKKKXNWWWWMMMMMMMMMMMMMMMMMMMMMMMMM");
                Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMWNX0OkkOO000KKKKXXXNWWMMWMMMWWNXXXXXXXl..:0WO'..cKWWMNl.dNNKl.cXNXNNWWWWMMWMMMMMMWWNXKKKKK0000OOOO00XNWMMMMMMMMMMMMMMMMMMMMMMMM");
                Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMWWNXOxddddxkkO0KKXKkOKXXNWWWWWWWWNXKKXXx..oKNNx;:kNWWWWWK:'x0: '0NK0XNNNNNNNNNWWWWWNXXKKKK000OOkxxdddxOXWWMMMMMMMMMMMMMMMMMMMMMMM");
                Console.WriteLine("MMMMMMMMMMMMMMMMWMWWN0kdollooooddxkkO0Oc,kXXXXXNNXKXXXXKdcOKl;xNNWWXXWWWWWMMWWKdloc,,lolo0XNNNNNNNNWNNXKKXKKK000OkkxxddooolloxOKNWMMMMMMMMMMMMMMMMMMMM");
                Console.WriteLine("MMMMMMMMMMMMMMMWWNXKkoc::cccllooodxxkk;.oKKKKXXXKol0XKKd';OKKXNN0k0NWWWWMMWWWXOOXWNXKKX0xkKXXXNNNNNNKx:l0XX0OOOOkxxddoollccc::clx0XWWWMMMMMMMMMMMMMMMM");
                Console.WriteLine("MMMMMMMMMMWWWWWNXKKKK0Oxocccccllodxxx:.lOO0KKKKXK0KXK0x,;OOx0NNXc.'ckNWWMWX0d::,cKWNNNNx..,ckKKKKXXOoco0Kxccc:cdxddoollccc::coxkO0KKKNWMWWMMMMMMMMMMMM");
                Console.WriteLine("MMMMMMMMWXK00KXXXXXXKKKKK0kxolcclodd;.ckkkOOO0Kk:oXNN0:'cl:.;KWK:cOo'oNWWNc.,xk;:KWNXNNo'od,'dO0XXxcONX0c;oOOc.cxdolcccclodkO0KKKKXXXXXKKKKNWMWMMMMMMM");
                Console.WriteLine("MMMMMMWNKOkkOOOOO00KKXXXKKKKKOkdooo;.lkkkkkkOOd..xNNNo.'lOk,:K0c:OW0,;KWWk. 'lcdXWNNNKo;oXKc.l0XKl.;0XKo,d0k:.,ddolccldxOKKKKKXKKKK00OOOOkkOKNMMMMMMMM");
                Console.WriteLine("MMMMMWKOkkkkkkkOOOOOO000KKKKKKKXOl'..;;;;;;;::' .oolo,.cdl,cOd,c0NNo.,odOO; .:dxdooxd;,dKNO'.:ooc..;oll:,;::,.:oolodk0KKKKKKKK00OOOOOOkkkkkkkOXWMMMMMM");
                Console.WriteLine("MMMMWNXKK00OkkkkkkkkOOOOO000KKX0c.;dOkxdoollooddloodOOxoloOX0xkNNNX0xdxOXNKOxddxkk00xdOXXXKkddkkkkdooodxxddkkoloxO0KKK000000OOOOOOOkkkkkkkkO00KNMMMMMM");
                Console.WriteLine("MMMMMMMMWWNNNXKK00OkkkkkOOOO00K0xkKXKKKOkddddddxkkkkk0KXXXXNNWWNNXXXNNNNNNNNNNNNWNNNWWNXXXKKXXK0OkkkxxxddolodkKXKKK00000OOOOOOkkkkkOO0KKXXNNWWWWMMMMMM");
                Console.WriteLine("MMMMMMWWNXXXNNNNNNNXKK00OOkkOOO00KKKKKKKK0kdllloooddddxO0KKXNWWNXKKXXXXNNNNNNNNNNNWWWWNNNXKK0Okxdddoollllldk0KKKK0000OOOkkkkOOO0KKXXNNNNNNNNNWMMMMMMMM");
                Console.WriteLine("MMMMMWNXKKKKKXXXXXXXXXNXXKK0OOkOOOO0000000K0Oxocclllooodxk00KXWNXKKKKXNWWNNXXNNNNWWWWWNNK00OkdooolllcccoxO0K0000O0OOOkkkkO00KXXXXXXXXXXXKKKKKXNWMMMMMM");
                Console.WriteLine("MMMWNXXKKKKKKKKKKKKXXXXXXXXXXKKK0OOOOOOOO000KKOxolccccllloxkO0XXXKKXXNWMWWNNNNNNWWWWWWXK0Okdolllllccldk000000OOOOOOOOO00KKXXXXXXKKKKKXXXKKKKKKXXWWMMMM");
                Console.WriteLine("WWWWNNXX00O0000000KKKKKKXXXXXXXXXXXK00OOOOOO00000kdlccccclloxO00KKXNWMMMMWWNNNNNWMMMWX00kdolllccccoxO0000OOOOOOOO00KXXXXXXXXXKKKKKKKKKKK0000KKXXNWWMMM");
                Console.WriteLine("WMWWWWN0kxxxxxxkkkOOOOO0000KKKXXXXXXXXXKK00OOO00OO0OxocccccllokO0KNMMMMMMMWWWNNNWWWWK0Oxolccc::ldk000OOOOOOO00KKXXXXXXXKKKKK0000OOOOkkkkkkxkk0NWWWMMMM");
                Console.WriteLine("WWWWWN0xxkxxxxxxxxkkkkkOOOOO0000KKKKKXXXXXXKK00OOOOO0Okdlc::ccoxO0XWMMMMMMMWWWNNWWNKOkolccc:cldOOOOOOOOO0KKXXXXXXXKKKK000OOOOOkkkxxxxxxxxxxxxk0NWWMMWW");
                Console.WriteLine("WNKK0OxddddddxddxxxxxxxxkkkOOOOOO00000KKKXXXXXXXK00OOOOOkdlc:cccdk0XWMMMMMMMMWWWWNKOxlcc:ccoxOOOOOO00KKXXXXXKKKKK0000OOOOkkkkkxxxxxxxxxxddxdddxOXNNNWW");
                Console.WriteLine("XxccccclccllloooooooddddxxxxxkkkOOO0000000KKKKXXXXXKK00OOOOxl::ccldOXWMMMMMMMWWWX0koccc:coxOOOO00KKKXXXKKKKK0000OOOOOkkkkxxxxdddddddooooollllllloooxXW");
                Console.WriteLine("kc:::::::::ccccllllooooooddddddxxxxkkkOO00000KKKKKKXXXXKK0OOOxocc:cokKWWMMMMMWWXOdcc::ldkOO00KKXXXKKKKK000000OOOkkkxxxdddddddoooooollllccccc:::::::cOW");
                Console.WriteLine("o::::::::::::::::ccclllooodddxxxxxxxxxkkkkOOO00000KKKKKKXXXKK0Okdc:clxKWMWWMMWNOoc::ldkO00KKXXKKKKK0000OOOkkkkxxxxdddddddddoooolllcccc::::::::::::::l0");
                Console.WriteLine("::::::::::::::::::::cccccccllllooddxxxkkkkkkkOOOOOO0000KKKKKXXKK0kdl:co0WWWMWKxl:clxO0KKKKKKK00000OOOOkkkkkxxxxxxdddddoollcccc::::::::::::::::::::c::d");
                Console.WriteLine("xxkkkkOOOO000000000000000OOOOOkkkOOOkkkkkkkkOOOOOOOOOOO00000KKKKKKKOxlcckXNX0dccox0KXXKKK0000OOOOOkkkkkkkkxxxxxxxxxxxxxxxxxkkkkkkkkkkkkkkkkkxxxxxdddod");
                Console.WriteLine("WWWWWMMMMMMMMWWMMMMMMMMMMMMMMMMMWWWWWWWWWWWNNNNXXXXXXKKKKKKKKKKKK0KKKOxlcdkxocok0KKK000000000000KKKKKKKKXXXXNNNNNWWWWWWMMMMMMMMMMMMMMMMMWWWWWWWWWWWWWN");
                Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWWWWWNNNXXXXX0xloxxkKXXXXXXXNNNNNWWWWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
                Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWNK0XNWWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n");*/
        // El Administrador
        string ADMIN = "Bibli!@gmail.com"; // Usuario del administrador

        // Bandera para mantener el programa en ejecución
        bool prog = true;

        // Comienza el programa
        while (prog)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");       
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("╔════════════════════════════╗");
            Console.WriteLine("║ Bienvenido a la Biblioteca ║");
            Console.WriteLine("╠─────────~~~~~~~~~~─────────╣");
            Console.WriteLine("║      ¿Tienes una cuenta?   ║");
            Console.WriteLine("║   1) Inicio de Sesión      ║");
            Console.WriteLine("║   2) Registrarse           ║");
            Console.WriteLine("║   3) Salir                 ║");
            Console.WriteLine("╚════════════════════════════╝");
            Thread.Sleep(700);
            Console.Write("Seleccione una opción: ");         
            string resp = Console.ReadLine();
            
            Console.Clear();
            switch (resp)
            {
                case "1":
                    InicioSesion(ADMIN);
                    break;
                case "2":
                    Registrarse();
                    break;
                case "3":
                    prog = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    break;
            }
        }
    }

    public static void InicioSesion(string ADMIN)
    {
        Console.WriteLine("\nInicio de Sesión");
        Console.Write("Usuario: ");
        string user = Console.ReadLine()!;

        if (user == ADMIN)
        {   Console.Clear();
            Console.WriteLine("\n Bienvenido Administrador.");
            Thread.Sleep(2000);
            Admin();
        }
        else if (User.Contains(user))
        {
            Console.Write("Contraseña: ");
            string pass = Console.ReadLine()!;
            if(Password[User.IndexOf(user)] == pass){
                Console.Clear();
                Console.WriteLine($"\n Bienvenido {user}");
                Thread.Sleep(2000);
                Userr(user);
            }
            else{
                Console.WriteLine("Credenciales incorrectas.");
                Console.ReadKey();
            }
            
        }
        else
        {
            Console.WriteLine("Credenciales incorrectas.");
            Console.ReadKey();
        }
    }

    public static void Registrarse()
    {
        bool Allow = true;
        Console.WriteLine("\nRegistro");
        Console.Write("Usuario: ");
        string user = Console.ReadLine()!;
        for(int i = 0; i < User.Count; i++){
            if(user == User[i]){
                Allow = !Allow;
            }
        }
        if(Allow){
            Console.Write("Contraseña: ");
            string pass = Console.ReadLine()!;
            User.Add(user);
            Password.Add(pass);
            cantidadUsuarios++;
            Console.WriteLine("Usuario registrado exitosamente.");
            Console.ReadKey();
        }else{
            Console.WriteLine("Este Usuario ya existe");
            Console.ReadKey();
            return;
        }
    }

    public static void Userr(string user)
    {
        // Todo relacionado con el usuario
        bool UserProg = true;
        while (UserProg)
        {
            Console.Clear();
            Console.WriteLine(user);
            Thread.Sleep(1000);
            Console.WriteLine("╔═════════════════════════════╗");
            Console.WriteLine("║  Bienvenido a la Biblioteca ║");
            Console.WriteLine("╠═════════════════════════════╣");
            Console.WriteLine("║    1) Catálogo de libros    ║");
            Console.WriteLine("║    2) Alquilar un libro     ║");
            Console.WriteLine("║    3) Salir                 ║");
            Console.WriteLine("╚═════════════════════════════╝");

            try
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int resp))
                {
                    switch (resp)
                    {
                        case 1:
                        Catalogo();
                        Console.ReadKey(); // Pausa para que el usuario pueda leer el catálogo
                        break;
                    
                        case 2:
                        LibroAlquilado();
                        Console.ReadKey();
                        break;

                        case 3:
                        UserProg = false;
                        break; 

                        default:
                        Console.WriteLine("Opción no válida.");
                        break;
                    
                    }
                }
                else {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }
            }    
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }

    public static void Admin()
    {
        bool AdminProg = true;
        while (AdminProg)
        {
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("│─────────────────────────────────────│");
            Console.WriteLine("│         Sistema de Gestión de       │");
            Console.WriteLine("│               Librería              │");
            Console.WriteLine("├─────────────────────────────────────┤");
            Console.WriteLine("│   1. Añadir Libro                   │");
            Console.WriteLine("│   2. Eliminar Libro                 │");
            Console.WriteLine("│   3. Listado de Libros              │");
            Console.WriteLine("│   4. Listado de Usuarios            │");
            Console.WriteLine("│   0. Salir                          │");
            Console.WriteLine("│─────────────────────────────────────│");
            Console.Write("\nIngrese su opción: ");

            int opcion = int.Parse(Console.ReadLine()!);

            switch (opcion)
            {
                case 1:
                    AñadirLibro();
                    break;
                case 2:
                    EliminarLibro();
                    break;    
                case 3:
                    ListarLibros();
                    Console.ReadKey();
                    break;
                case 4:
                    ListarUsuarios();
                    Console.ReadKey();
                    break;
                case 0:
                    AdminProg = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, intente nuevamente.");
                    break;
            }
        }
    }

    public static void Catalogo()
    {
        Console.WriteLine("Catálogo de libros:");
        for (int i = 0; i < cantidadLibros; i++)
        {
            Console.WriteLine($"Título: {titulos[i]}, ----------Autor: {autores[i]}, Año: {años[i]}");
        }
    }

    public static void AñadirLibro()
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
            Console.WriteLine("La estantería de libros está llena.");
        }
    }
    public static void EliminarLibro()
    {
        Console.WriteLine("Ingrese el Título del Libro que desea eliminar: ");
        string Libro = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(Libro))
        {
        Console.WriteLine("Debe ingresar un título de libro válido.");
        return;
        }
        bool encontrado = false;

        Console.WriteLine($"El libro que quiere eliminar es: {Libro} ");
        // Buscar el índice del libro a eliminar
        for (int i = 0; i < titulos.Length; i++)
        {
            if (Libro == titulos[i]){
                Console.WriteLine($"El libro '{Libro}' se ha podido exitosamente.");
                for (int j = i; j < cantidadLibros - 1; j++){
                titulos[j] = titulos[j + 1];
                autores[j] = autores[j + 1];
                años[j] = años[j + 1];
                        }
                    // Limpiar el último elemento, ya que fueron movidos hacia adelante
                    titulos[cantidadLibros - 1] = string.Empty;
                    autores[cantidadLibros - 1] = string.Empty;
                    años[cantidadLibros - 1] = 0;

                    // Disminuir el conteo de libros
                    cantidadLibros--;
                    encontrado = true;
            }   
        } 
           
            if (!encontrado)
            {
                Console.WriteLine("El libro que intenta eliminar no se encuentra en la libreria.");
            }
    }

    public static void LibroAlquilado()
    {
        Console.WriteLine("Ingrese el Título del Libro que desea alquilar: ");
        string Libro = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(Libro))
        {
            Console.WriteLine("Debe ingresar un título de libro válido.");
            return;
        }
        bool encontrado = false;

        Console.WriteLine($"El libro que quiere alquilar es: {Libro} ");
        // Buscar el índice del libro a eliminar
        for (int i = 0; i < titulos.Length; i++)
        {
            if (Libro == titulos[i]){
                Console.WriteLine($"El libro '{Libro}' se le podido alquilar exitosamente.");
                for (int j = i; j < cantidadLibros - 1; j++){
                    titulos[j] = titulos[j + 1];
                    autores[j] = autores[j + 1];
                    años[j] = años[j + 1];
                }
                // Limpiar el último elemento, ya que fueron movidos hacia adelante
                titulos[cantidadLibros - 1] = string.Empty;
                autores[cantidadLibros - 1] = string.Empty;
                años[cantidadLibros - 1] = 0;

                // Disminuir el conteo de libros
                cantidadLibros--;
                encontrado = true;
            }   
        } 
           
            if (!encontrado)
            {
                Console.WriteLine("El libro no se encuentra en la libreria.");
            }
    }
    public static void ListarLibros()
    {
        if (cantidadLibros == 0)
        {
            Console.WriteLine("No hay libros disponibles.");
        }
        else
        {
            Console.WriteLine("Lista de Libros:");
            for (int i = 0; i < cantidadLibros; i++)
            {
                Console.WriteLine($"Título: {titulos[i]}------------------ Autor: {autores[i]} - Año: {años[i]}");
            }
        }
    }

    public static void ListarUsuarios()
    {
        if (cantidadUsuarios == 0)
        {
            Console.WriteLine("No hay usuarios registrados.");
        }
        else
        {
            Console.WriteLine("Lista de Usuarios:");
            for (int i = 0; i < cantidadUsuarios; i++)
            {
                Console.WriteLine($"Usuario: {User[i]}");
            }
        }
    }
}

