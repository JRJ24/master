public class User {
    private OracleConnectivy connectivy;
    private String userName;
    private String passwordUser;
    

    public User(String username, String passwordUser, OracleConnectivy connectivy) {
        this.userName = username;
        this.passwordUser = passwordUser;
        this.connectivy = connectivy;
    }
    
    public String getUserName() {
        return this.userName;
    }

    public String getPasswordUser() {
        return this.passwordUser;
    }

    public OracleConnectivy getConnectivy() {
        return this.connectivy;
    }

    
}


