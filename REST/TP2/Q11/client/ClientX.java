import java.util.Scanner;
import javax.ws.rs.client.Client;
import javax.ws.rs.client.ClientBuilder;
import javax.ws.rs.client.WebTarget;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;
import org.glassfish.jersey.client.ClientConfig;

public class ClientX {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Merci de bien vouloir saisir le nom du contact à chercher :");
        String nom = sc.nextLine();

        ClientConfig cliConf = new ClientConfig();
        Client clnt = ClientBuilder.newClient(cliConf);

        try {
            WebTarget wt = clnt.target("http://localhost:8080/Rest2Q10/carnet");
            Response response = wt.path("/carnet10/").path(nom)
                    .request(MediaType.TEXT_PLAIN_TYPE)
                    .get();

            if (response.getStatus() == Response.Status.OK.getStatusCode()) {
                System.out.println("Le numéro de " + nom + " est : " + response.readEntity(String.class));
            } else if (response.getStatus() == Response.Status.NOT_FOUND.getStatusCode()) {
                System.out.println("Le contact est introuvable : " + response.readEntity(String.class));
            } else {
                System.out.println("Erreur : " + response.readEntity(String.class));
            }
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            clnt.close();
        }
    }
}
