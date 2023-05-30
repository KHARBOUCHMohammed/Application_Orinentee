

import javax.ws.rs.client.*;
import javax.ws.rs.core.*;
import java.util.Scanner;
import org.glassfish.jersey.client.ClientConfig;

public class  ClientX{
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Merci de bien vouloir saisir le nom :");
        String nom = sc.nextLine();
        System.out.println("Merci de bien vouloir saisir le numéro : ");
        String num = sc.nextLine();


        ClientConfig cliConf = new ClientConfig();
        Client clnt = ClientBuilder.newClient(cliConf);
        WebTarget webTarg = clnt.target("http://localhost:8080/Rest2Q5/carnet");
        
        Form form = new Form();
            form.param("numero", num);
            form.param("name", nom);

        Response response = webTarg.path("addContact").request().post(Entity.entity(form, MediaType.APPLICATION_FORM_URLENCODED));
        if (response.getStatus() == Response.Status.CREATED.getStatusCode()) {

            String url = response.getHeaderString("Location");
            WebTarget tgt2 = clnt.target(url);
            String numajt = tgt2.request().get(String.class);
            System.out.println("Le numéro du contact ajouté est : " + numajt);
        } else {
            String message = response.readEntity(String.class);
            System.err.println(message);
        }
        response.close();
        clnt.close();
    }
}