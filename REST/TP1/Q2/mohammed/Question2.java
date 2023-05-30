package mohammed;
import javax.ws.rs.*;


@Path("/Question2")	
public class Question2{



	@GET
	@Produces("text/plain")
	public String saluer(){
	
		String msg="Mohammed";
		System.out.println(msg);
		return msg;
	}
	
	
	// Methode Xml fichier xml
	@Path("/Hello")
	@GET
	@Produces("text/xml")
	public String hello(){
	
		String msg="<?xml version=\"1.0\" encoding=\"UTF-8\"?> <MabalisXMl><string>Bonjour Mohammed</string></MabalisXMl>";
		System.out.println(msg);
		return msg;
	}
	
	
	//Methode hello fichier html
	@Path("/Hola")
	@GET
	@Produces("text/html")
	public String ola(){
	
		String msg="<h1> Hello Kharbouch </h1>";
		System.out.println(msg);
		return msg;
	}
}
