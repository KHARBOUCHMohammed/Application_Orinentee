import javax.ws.rs.client.Client;
import javax.ws.rs.client.ClientBuilder;
import javax.ws.rs.client.WebTarget;
import javax.ws.rs.core.Response;

public class ClientRest {

    private static final String BASE_URI = "http://localhost:8080/P2_Q13/rest/annuaire";

    public static void main(String[] args) {
        Client client = ClientBuilder.newClient();

        // Appadmin : accès autorisé
        WebTarget target = client.target(BASE_URI).path("/contacts");
        Response response = target.request().header("Authorization", "Basic YXBwYWRtaW46YXBwdXNlcg==").get();
        System.out.println("Appadmin - GET /contacts : " + response.getStatus());

        // Appusers : accès autorisé
        target = client.target(BASE_URI).path("/contacts");
        response = target.request().header("Authorization", "Basic YXBwdXNlcjp1c2VyMQ==").get();
        System.out.println("Appusers - GET /contacts : " + response.getStatus());

        // Appadmin : accès autorisé
        target = client.target(BASE_URI).path("/contact/1");
        response = target.request().header("Authorization", "Basic YXBwYWRtaW46YXBwdXNlcg==").delete();
        System.out.println("Appadmin - DELETE /contact/1 : " + response.getStatus());

        // Appusers : accès refusé
        target = client.target(BASE_URI).path("/contact/2");
        response = target.request().header("Authorization", "Basic YXBwdXNlcjp1c2VyMQ==").delete();
        System.out.println("Appusers - DELETE /contact/2 : " + response.getStatus());

        client.close();
    }
}
