public class AgendaContactos{
    private Conctatos[] contactos = new Conctatos[10];
    OracleConnectivy connectivy = new OracleConnectivy();


    public void agregarContacto(Conctatos contacto) {
        for (int i = 0; i < contactos.length; i++) {
            if (contactos[i] == null) {
                contactos[i] = contacto;
                break;
            }
        }
    }

    public void insertarDatosBD() {
        for (int i = 0; i < contactos.length; i++) {
            if (contactos[i] != null) {
                connectivy.insertarContacto(contactos[i]);
                //contactos[i] = null;
            }
        }
    }

    public void mostrarContactos() {
        connectivy.mostrarContactos();
    }

    public void buscarContactoAgenda(String name) {
        connectivy.buscarContacto(name);
    }

    public void eliminarContacto(String name) {
        connectivy.deleteContacto(name);
    }
}