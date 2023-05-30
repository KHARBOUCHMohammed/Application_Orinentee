import javax.ws.rs.client.*;
import java.util.*;
import java.lang.*;
import org.glassfish.jersey.client.*;


public class ClienttX{


	public static void main(String[] args) {


		ClientConfig cfgClient =new ClientConfig();
   
		Client clt = ClientBuilder.newClient(cfgClient);
   
		WebTarget varx =clt.target("http://localhost:8080/RestQ2");
			
   
	   String Text=	varx.path("/Question2").request().get(String.class);
	   System.out.println(" Message envoyé est:  " +Text);
   
   
	   // path 2
	   String Text2=varx.path("/Question2").path("/Hello").request().get(String.class);
   
	   System.out.println(" Message envoyé est:  " +Text2);
   
	   //Path 3
	   String Text3=varx.path("/Question2").path("/Hola").request().get(String.class);
   
	   System.out.println(" Message envoyé est:  "+Text3);
	   
   }

}