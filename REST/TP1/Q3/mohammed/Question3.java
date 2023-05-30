package mohammed;
import javax.ws.rs.*;


@Path("/Question3/{nom}")	
public class Question3{


@GET

@Produces("text/plain")
public String saluer(@PathParam("nom") String nom){

	String msg=" Bonjour " +nom;
	System.out.println(msg);
	return msg;
}

}
