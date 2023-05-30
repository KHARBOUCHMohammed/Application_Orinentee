import javax.ws.rs.client.*;
import java.util.*;
import java.lang.*;
import javax.ws.rs.core.Response;
import org.glassfish.jersey.client.*;

public class ClientX{
    public static void main(String[] args) {
        ClientConfig cfgClient = new ClientConfig();
        Client clt = ClientBuilder.newClient(cfgClient);
        WebTarget varx = clt.target("http://localhost:8080/RestQ1");

        String text = varx.path("/Question1").request().get(String.class);
        System.out.println(" Message envoyé est:" +text);

        Response response = varx.path("/Question1").request().get();
        System.out.println("Status : " + response.getStatus());
    }
}
