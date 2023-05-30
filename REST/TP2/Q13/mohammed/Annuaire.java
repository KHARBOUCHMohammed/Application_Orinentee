package mohammed ;
import javax.annotation.security.RolesAllowed;
import javax.ws.rs.*;
import javax.ws.rs.core.MediaType;
import java.util.ArrayList;
import java.util.List;

@Path("/annuaire")
public class Annuaire {
    private static List<Contact> contacts = new ArrayList<>();

    @GET
    @Path("/contacts")
    @Produces(MediaType.APPLICATION_XML)
    @RolesAllowed({"appadmin", "appusers"})
    public List<Contact> getListeContacts() {
        return contacts;
    }

    @DELETE
    @Path("/contact/{numero}")
    @RolesAllowed("appadmin")
    public void supprimerContact(@PathParam("numero") String numero) {
        contacts.removeIf(contact -> contact.getNumero().equals(numero));
    }

}
