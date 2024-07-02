using System;
using System.Collections.Generic;

class Program{
    static void Main(){
        List<string> User = new List<string>{"Jonaifry"};
        List<string>Password = new List<string>{"1234"};
        string ADMIN = "Bibli!@gmail.com";
        bool prog = true;
        string resp, user, pass;
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

                    for(int i = 0; i < User.Count(); i++){
                        if(user == User[i] || pass == Password[i]){
                            Console.WriteLine($"Bienvenido {user}");
                            Userr();
                            break;
                        }
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

                case "2":
                    Console.WriteLine("\n Registro");
                    Console.Write("\n Usuario: ");
                    user = Console.ReadLine()!;
                    Console.Write("\n Contraseña: ");
                    pass = Console.ReadLine()!;

                    User.Add(user);
                    Password.Add(pass);
                break;
            }

        }
        
    }

    public static void Userr(){
        // Todo relacionado con el usuario
    }

    public static void Admin(){
        // Todo relacionado con el Admin
    }
}


