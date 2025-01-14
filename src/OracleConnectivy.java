import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.sql.ResultSet;
public class OracleConnectivy {
    private static final String URL = "jdbc:oracle:thin:@//localhost:1521/XEPDB1";
    private static final String User = "userAgent";
    private static final String password = "userAgent";

    public void insertarContacto(Conctatos conctatos){
        String sql = "INSERT INTO CONTACTOS (ID_CONTACT, NAME_CONTACT, PHONE_NUMBER, EMAIL, ADDRESS, BIRTHDATE, NOTES, GROUP_CONTACT, DATE_LAST_CONCTACT) VALUES (ID_CONTACT_SE.NEXTVAL, ?, ?, ?, ?, TO_DATE(?, 'YYYY-MM-DD'), ?, ?, TO_DATE(?, 'YYYY-MM-DD'))";

        //System.out.println(conctatos.getDateLastContact());
        try(Connection conn = DriverManager.getConnection(URL, User, password);
            PreparedStatement pstmet = conn.prepareStatement(sql);){
                
            pstmet.setString(1, conctatos.getName());
            pstmet.setString(2, conctatos.getPhoneNumber());
            pstmet.setString(3, conctatos.getEmail());
            pstmet.setString(4, conctatos.getAddress());
            pstmet.setString(5, conctatos.getBirthDate().toString());
            pstmet.setString(6, conctatos.getNotes());
            pstmet.setString(7, conctatos.getGroup());
            pstmet.setString(8, conctatos.getDateLastContact().toString()); 
        
            int rowsAffected = pstmet.executeUpdate();
            System.out.println("Contacto insertado correctamente. Filas Afectadas "+rowsAffected);
        }catch (SQLException e) {
            System.err.println("Error al insertar el contacto: " + e.getMessage());
        }
    }

    public void insertarUser(User user){
        String sql = "INSERT INTO USERS (ID_USER,USERNAME, PASSWORDUSER) VALUES (ID_USER_SEQ.NEXTVAL, ?, ?)"; 
        try(Connection conn = DriverManager.getConnection(URL, User, password);
            PreparedStatement pstmet = conn.prepareStatement(sql);){
                //pstmet.setString(0, sql);
                pstmet.setString(1, user.getUserName());
                pstmet.setString(2, user.getPasswordUser());
                int rowsInserted = pstmet.executeUpdate();
                if (rowsInserted > 0) {
                    System.out.println("Ha iniciado sesion");
                } else {
                    System.out.println("No ha iniciado sesion correctamente.");
                }
        }catch(SQLException e){
            System.err.println("Error al insertar el usuario: " + e.getMessage());
        }
    }


    public void mostrarContactos(){
        String sql = "SELECT NAME_CONTACT, PHONE_NUMBER FROM CONTACTOS";
        try(Connection conn = DriverManager.getConnection(URL, User, password);
            PreparedStatement pstmet = conn.prepareStatement(sql);){
                ResultSet rs = pstmet.executeQuery();
                while(rs.next()){
                    String name = rs.getString("NAME_CONTACT");
                    String phoneNumber = rs.getString("PHONE_NUMBER");
                    System.out.println(name + " - " + phoneNumber);
                }
        }catch (SQLException e) {
            System.err.println("Error al mostrar los contactos: " + e.getMessage());
        }
    }

    public void buscarContacto(String name){
        String sql = "SELECT * FROM CONTACTOS WHERE NAME_CONTACT = ?";
        try(Connection conn = DriverManager.getConnection(URL, User, password);
            PreparedStatement pstmet = conn.prepareStatement(sql);){
                pstmet.setString(1, name);
                ResultSet rs = pstmet.executeQuery();
                while(rs.next()){
                    String nameContact = rs.getString("NAME_CONTACT");
                    String phoneNumber = rs.getString("PHONE_NUMBER");
                    String email = rs.getString("EMAIL");
                    String address = rs.getString("ADDRESS");
                    String birthdate = rs.getString("BIRTHDATE");
                    String notes = rs.getString("NOTES");
                    String group = rs.getString("GROUP_CONTACT");
                    String dateLastContact = rs.getString("DATE_LAST_CONCTACT");

                    System.out.println("Nombre: " + nameContact);
                    System.out.println("Telefono: " + phoneNumber);
                    System.out.println("Email: " + email);
                    System.out.println("Direccion: " + address);
                    System.out.println("Fecha de Nacimiento: " + birthdate);
                    System.out.println("Notas: "+ notes);
                    System.out.println("Grupo: "+ group);
                    System.out.println("Ultima fecha que fue contactado: "+dateLastContact);
                }
        }catch (SQLException e) {
                System.err.println("Error al consultar el contacto: " + e.getMessage());
            }
    }

    public void deleteContacto(String name){
        String sql = "DELETE FROM CONTACTOS WHERE NAME_CONTACT = ?";
        try(Connection conn = DriverManager.getConnection(URL, User, password);
            PreparedStatement pstmet = conn.prepareStatement(sql);){
                pstmet.setString(1, name);
                int rowsDeleted = pstmet.executeUpdate();
                if (rowsDeleted > 0) {
                    System.out.println("Contacto eliminado correctamente.");
                } else {
                    System.out.println("No se ha podido eliminar el contacto.");
                }
        }catch (SQLException e) {
            System.err.println("Error al eliminar el contacto: " + e.getMessage());
        }
    }

    public void updateContacto(String name, String phoneNumber){
        String sql = "UPDATE CONTACTOS SET PHONE_NUMBER = ? WHERE NAME_CONTACT = ?";
        try(Connection conn = DriverManager.getConnection(URL, User, password);
            PreparedStatement pstmet = conn.prepareStatement(sql);){
                pstmet.setString(1, phoneNumber);
                pstmet.setString(2, name);
                int rowsUpdated = pstmet.executeUpdate();
                if (rowsUpdated > 0) {
                    System.out.println("Contacto actualizado correctamente.");
                } else {
                    System.out.println("No se ha podido actualizar el contacto.");
                }
        }catch (SQLException e) {
            System.err.println("Error al actualizar el contacto: " + e.getMessage());
        }
    }
}
    


