import javax.ws.rs.client.*;
import java.util.*;
import java.lang.*;
import org.glassfish.jersey.client.*;


public class ClientX{


 public static void main(String[] args) {


 	ClientConfig cfgClient =new ClientConfig();

 	Client clt = ClientBuilder.newClient(cfgClient);

 	WebTarget varx =clt.target("http://localhost:8080/RestQ4");

	String text=varx.path("/Question4/Hello").request().get(String.class);

	System.out.println(" Votre message est:" +text);
	
}

}