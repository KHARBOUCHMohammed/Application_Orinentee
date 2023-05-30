import javax.ws.rs.client.*;
import org.glassfish.jersey.client.*;



public class ClientX {
	
		public static void main(String[] args){
			
			ClientConfig cliConf = new ClientConfig();
			Client clt = (Client) ClientBuilder.newClient(cliConf);
			WebTarget wT = clt.target("http://localhost:8080/Rest2Q2/annuaire/carnet");
			String rslt = wT.path("/Mohammed").request().get(String.class);
			String rslt2 = wT.path("/kharbouch").request().get(String.class);
			String rslt3 = wT.path("/test").request().get(String.class);
			System.out.println("Numero de Mohammed est: "+rslt);
			System.out.println("Numero de Kharbouch est: "+rslt2);
			System.out.println("Numero : "+rslt3);
			
		}
	
}