package mohammed;

import java.util.Arrays;

import javax.ws.rs.*;

@Path("/annuaire")
public class Annuaire {
	private static Carnet CARNET = new Carnet();
	@Path("/carnet")
	@GET
	@Produces("text/html")
	public String getContacts() {
		return CARNET.getContacts().size() == 0 ? "Liste Vide" : CARNET.toString();
	}


}