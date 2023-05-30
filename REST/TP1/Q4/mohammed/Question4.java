package mohammed;
import javax.ws.rs.*;


@Path("/Question4")	
public class Question4{
	@GET
	@Produces("text/plain")
	public String saluer(){
	
		String msg="Mohammed";
		System.out.println(msg);
		return msg;
	}
	
	@Path("Hello")
	@GET
	@Produces("text/plain")
	public String saluerParam(@DefaultValue("inconnue") @QueryParam("name") String name, @DefaultValue("inconnue") @QueryParam("name1") String name1) {
		
		String msg="Bonjour args1 "+name+"\n"+"Bonjour arg2 " +name1;
		System.out.println(msg);
		return msg;
	}
}
