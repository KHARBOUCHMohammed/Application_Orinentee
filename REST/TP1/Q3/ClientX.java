import javax.ws.rs.client.*;
import java.util.*;
import java.lang.*;
import org.glassfish.jersey.client.*;


public class ClientX{


 public static void main(String[] args) {


 	ClientConfig cfgClient =new ClientConfig();

 	Client clt = ClientBuilder.newClient(cfgClient);

 	WebTarget varx =clt.target("http://localhost:8080/RestQ3");

	String text=varx.path("/Question3/Mohammed").request().get(String.class);

	System.out.println(" Message envoyé est:" +text);
	
}

}