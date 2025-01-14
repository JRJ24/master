import java.util.Date;
import java.time.LocalDate;
//import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.time.format.DateTimeParseException;
public class Conctatos extends AgendaContactos{
    private String name; // nombre del contacto
    private String phoneNumber; // número de teléfono del contacto
    private String email; // dirección de correo electrónico del contacto
    private String address; // dirección del contacto
    private Date birthDate; // fecha de cumpleaños del contacto
    private String notes; // notas adicionales sobre el contacto 
    private String group; // grupo al que pertenece el contacto
    private Date dateLastContact; // fecha y hora de la última vez que se contactó con el contacto

    //private AgendaContactos agendaContactos;

    public Conctatos(String name, String phoneNumber, String email, String address, String notes, String group) {
        this.name = name;
        this.phoneNumber = phoneNumber;
        this.email = email;
        this.address = address;
        this.birthDate = getBirthDate();
        this.notes = notes;
        this.group = group;
        this.dateLastContact = getDateLastContact();
    }

    public String getName() {
        return this.name;
    }

    public String getPhoneNumber() {
        return this.phoneNumber;
    }

    public String getEmail() {
        return this.email;
    }

    public String getAddress() {
        return this.address;    
    }

    public String getNotes() {
        return this.notes;
    }

    public String getGroup() {
        return this.group;
    }


    public void setBirthDate(String birthDate) {
        String[] formatos = {
            "dd-MM-yyyy",
            "yyyy-MM-dd",
            "dd/MM/yyyy",
            "yyyy/MM/dd",
            "ddMMyyyy",
            "yyyyMMdd"
        };
        LocalDate date = null;

        for (String formato : formatos) {
            try {
                DateTimeFormatter formatter = DateTimeFormatter.ofPattern(formato);
    
                if ((formato.equals("ddMMyyyy") && birthDate.length() == 8) || (formato.equals("yyyyMMdd") && birthDate.length() == 8)) {
                    date = LocalDate.parse(birthDate, formatter);
                    break;  
                }

                if (!formato.equals("ddMMyyyy") && !formato.equals("yyyyMMdd")) {
                    date = LocalDate.parse(birthDate, formatter);
                    break;
                }
            } catch (DateTimeParseException ignored) {
                
            }
        }

        if(date == null){
            System.err.println("Formato de fecha no reconocido: " + birthDate);
        }    
        else{
            this.birthDate = java.sql.Date.valueOf(date);
        }
    }

    public Date getBirthDate(){
        return this.birthDate;
    }

    public void setDateLastContact(String DateLastContact) {
        
        String[] formatos = {
            "dd-MM-yyyy",
            "yyyy-MM-dd",
            "dd/MM/yyyy",
            "yyyy/MM/dd",
            "ddMMyyyy",
            "yyyyMMdd"
        };
        LocalDate date = null;

        for (String formato : formatos) {
            try {
                DateTimeFormatter formatter = DateTimeFormatter.ofPattern(formato);
    
                if ((formato.equals("ddMMyyyy") && DateLastContact.length() == 8) || (formato.equals("yyyyMMdd") && DateLastContact.length() == 8)) {
                    date = LocalDate.parse(DateLastContact, formatter);
                    break; 
                }

                if (!formato.equals("ddMMyyyy") && !formato.equals("yyyyMMdd")) {
                    date = LocalDate.parse(DateLastContact, formatter);
                    break;
                }
            } catch (DateTimeParseException ignored) {}
        }
    
        if (date == null) {
            System.err.println("Formato de fecha no reconocido: " + DateLastContact);
        } else {
            this.dateLastContact = java.sql.Date.valueOf(date);
            //System.out.println("Fecha convertida: " + dateLastContact);
        }
    }

    public Date getDateLastContact() {
        return this.dateLastContact;
    }
}
