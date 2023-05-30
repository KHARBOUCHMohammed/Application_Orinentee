import javax.ws.rs.client.*;
import org.glassfish.jersey.client.*;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;

import org.glassfish.jersey.client.*;
import mohammed.Contact;



public class ClientX {
	
		public static void main(String[] args){
			
		ClientConfig cliConf = new ClientConfig();
		Client client = (Client) ClientBuilder.newClient(cliConf);
		WebTarget webTarg = client.target("http://localhost:8080/Rest2Q3/annuaire");

		 Form form = new Form();
		 form.param("num", "123456789");
		 form.param("name", "test");

		 Response result = webTarg.path("/ajtContactx").request(MediaType.APPLICATION_FORM_URLENCODED)
		 		.post(Entity.form(form));
			
		}
	
}