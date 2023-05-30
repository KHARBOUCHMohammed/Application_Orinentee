package mohammed;
import javax.ws.rs.*;


@Path("/Question1")	
public class Question1{


@GET
@Produces("text/plain")
public String saluer(){

	String msg=" Mohammed";
	System.out.println(msg);
	return msg;
}
}
