package mohammed;

import javax.ws.rs.WebApplicationException;
import javax.ws.rs.core.Response;

public class ContactNotFoundException extends WebApplicationException {
    public ContactNotFoundException() {
        super(Response.status(Response.Status.NOT_FOUND).entity("Contact ..... inconnu").build());
    }
}
