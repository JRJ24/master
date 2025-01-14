import java.io.Console;
//import java.util.ArrayList;

public class AppAgenda {
    public static void main(String[] args) {
        Console console = System.console(); 
        AgendaContactos agendaContactos = new AgendaContactos(); 
        Commands commands = new Commands();
        //Conctatos[] contactos = new Conctatos[10];
        System.out.println("Username: ");
        String userName = console.readLine();
        System.out.println("Password: ");
        char[]password = console.readPassword();
        String passwordUser = new String(password);
        
        OracleConnectivy connectivy = new OracleConnectivy();
        User user = new User(userName, passwordUser, connectivy);
        user.getConnectivy().insertarUser(user);
        while (true) {
            if(user.getUserName() != null && user.getPasswordUser() != null) {
                System.out.println("Agenda de Contactos");
                System.out.println("1. Agregar Contacto");            
                System.out.println("2. Mostrar Contactos");
                System.out.println("3. Buscar Contacto");
                System.out.println("4. Eliminar Contacto");
                System.out.println("5. Actualizar Contacto");
                System.out.println("6. Salir");
                System.out.print("Opcion: ");
                String opcion = console.readLine();
                switch (opcion) {
                    case "1":
                        commands.commands();
                        System.out.print("Nombre: ");
                        String name = console.readLine();
                        System.out.print("Telefono: ");
                        String phoneNumber = console.readLine();
                        System.out.print("Email: ");
                        String email = console.readLine();
                        System.out.print("Direccion: ");
                        String address = console.readLine();
                        System.out.print("Fecha de Nacimiento: ");
                        String birthDate = console.readLine();
                        System.out.print("Notas: ");
                        String notes = console.readLine();
                        System.out.print("Grupo: ");
                        String group = console.readLine();
                        System.out.print("Fecha de Ultimo Contacto: ");
                        String DateLastContact = console.readLine();
                        Conctatos contacto = new Conctatos(name, phoneNumber, email, address, notes, group);
                        contacto.setBirthDate(birthDate);
                        contacto.setDateLastContact(DateLastContact);
                        contacto.agregarContacto(contacto);
                        contacto.insertarDatosBD();
                        try{
                            Thread.sleep(2000);
                            commands.commands();
                        }
                        catch(InterruptedException ex){
                            ex.printStackTrace();
                        }
                        break;
                    case "2":  
                        commands.commands();
                        System.out.println("Contactos:");              
                        agendaContactos.mostrarContactos();
                        try{
                            Thread.sleep(5000);
                            commands.commands();
                        }
                        catch(InterruptedException ex){
                            ex.printStackTrace();
                        }
                        break;
                    case "3":
                        commands.commands();
                        System.out.print("Buscar Contacto: ");
                        String buscarContacto = console.readLine();
                        agendaContactos.buscarContactoAgenda(buscarContacto);
                        try{
                            Thread.sleep(5000);
                            commands.commands();
                        }
                        catch(InterruptedException ex){
                            ex.printStackTrace();
                        }
                        break;
                    case "4":
                        commands.commands();
                        System.out.println("Ingresa el nombre del contacto:");
                        String nameContact = console.readLine();
                        agendaContactos.eliminarContacto(nameContact);
                        try{
                            Thread.sleep(5000);
                            commands.commands();  
                        }
                        catch(InterruptedException ex){
                            ex.printStackTrace();
                        }
                        break;
                    case "5":
                        commands.commands();
                        System.out.println("Ingresa el conctacto que quiere actualizar");
                        String nameContacto = console.readLine();
                        System.out.println("Ingresa el nuevo telefono");
                        String phone = console.readLine();
                        connectivy.updateContacto(nameContacto, phone);
                        try{
                            Thread.sleep(5000);
                            commands.commands();
                        }
                        catch(InterruptedException ex){
                            ex.printStackTrace();
                        }
                        break;
                    case "6":
                            System.exit(0);
                        break;
                    default:
                        System.out.println("Opcion Invalida");
                }
            }
            
        }
    }
}

