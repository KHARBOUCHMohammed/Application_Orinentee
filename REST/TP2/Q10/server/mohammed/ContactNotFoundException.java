package mohammed;

import javax.ws.rs.WebApplicationException;
import javax.ws.rs.core.Response;

public class ContactNotFoundException extends WebApplicationException {
    
    public ContactNotFoundException() {
        super(Response.Status.NOT_FOUND);
    }
    
    public ContactNotFoundException(String message) {
        super(Response.status(Response.Status.NOT_FOUND).entity(message).build());
    }
    
    public Response getResponse() {
        return Response.status(Response.Status.NOT_FOUND).entity("Ce contact est inconnu").build();
    }
}
