package mohammed;

import java.util.Arrays;

import javax.ws.rs.*;

@Path("/")
public class Annuaire {
	private static Carnet CARNET = new Carnet();
	@Path("/carnet")
	@GET
	@Produces("text/html")
	public String getContacts() {
		return CARNET.getContacts().size() == 0 ? "Liste Vide" : CARNET.toString();
	}


	@Path("/carnet/{name}")
	@GET
	@Produces("text/html")
	public String getContactNum(@PathParam("name") String name){
		for(Contact contact : CARNET.getContacts()) {
			if(contact.getNom().equals(name))
				return contact.getNumero();
		}
		return "Inconnu";	
		
	}
	@POST
	@Path("/ajtContactx")
	
	public String ajtContactx(@FormParam("name") String name, @FormParam("numero") String numero) {
		for (Contact contact : CARNET.getContacts()) {
			if (contact.getNom().equals(name))
				return "Contact ... déjà existant";
		}
		Contact newContact = new Contact(name, numero);
		CARNET.ajtContact(newContact);
		// return "contact crée avec succee";
		return "<a href=\"http://localhost:8080/Rest2Q4/carnet/carnet/" + newContact.getNom()
				+ "\">afficher numero du contact</a> <b>" +newContact.getNom()+ " </b>";

	}






}