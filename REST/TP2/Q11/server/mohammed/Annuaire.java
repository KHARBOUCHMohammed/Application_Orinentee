package mohammed;

import java.util.Arrays;

import javax.ws.rs.*;

import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;
import java.util.HashMap;
import java.util.Map;

import javax.ws.rs.*;
import javax.ws.rs.core.Context;
import javax.ws.rs.core.Cookie;
import javax.ws.rs.core.HttpHeaders;
import javax.ws.rs.core.NewCookie;
import java.util.List;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
// import org.springframework.stereotype.Controller;
// import org.springframework.web.bind.annotation.GetMapping;
// import org.springframework.web.bind.annotation.ResponseBody;

import java.net.HttpCookie;


import javax.inject.Inject;
import javax.ws.rs.GET;
import javax.ws.rs.Path;

import javax.ws.rs.core.HttpHeaders;


@Path("/")
public class Annuaire {
    private static Carnet CARNET = new Carnet();  // Définition d'une instance de la classe Carnet

    // Route qui permet de récupérer les contacts
    @Path("/carnet")
    @GET
    @Produces("text/html")
    public String getContacts() {
        // Si la liste des contacts est vide, on retourne "Liste Vide", sinon on retourne la représentation de la liste des contacts
        return CARNET.getContacts().size() == 0 ? "Liste Vide" : CARNET.toString();
    }

    // Route qui permet de vérifier si un contact existe
    /*@Path("/carnet/{name}")
    @GET
    @Produces("text/html")
    public String getContactNum(@PathParam("name") String name){
        for(Contact contact : CARNET.getContacts()) {
            if(contact.getNom().equals(name))
                return contact.getNumero();
        }
        return "Inconnu";    
    }*/

    // Route qui permet d'ajouter un contact
    @POST
    @Path("/ajtContactx")
    public String ajtContactx(@FormParam("name") String name, @FormParam("numero") String numero) {
        // Vérifier si un contact existe déjà avec le même nom, si oui, retourner un message d'erreur
        for (Contact contact : CARNET.getContacts()) {
            if (contact.getNom().equals(name))
                return "Contact ... déjà existant";
        }
        // Si le contact n'existe pas, on crée une nouvelle instance de la classe Contact avec le nom et le numéro donnés en paramètre
        Contact newContact = new Contact(name, numero);
        // On ajoute le nouveau contact à la liste des contacts
        CARNET.ajtContact(newContact);
        return "contact crée avec succee";
    }

    // Route qui permet d'ajouter un contact et de retourner un lien pour afficher le numéro de téléphone de ce contact
    @Path("/addContact")
    @POST
    @Produces("text/html")
    public String addContact(@FormParam("name") String name, @FormParam("numero") String numero) {
        // Vérifier si un contact existe déjà avec le même nom, si oui, retourner un lien pour afficher son numéro de téléphone
        for (Contact contact : CARNET.getContacts()) {
            if (contact.getNom().equals(name))
                return "<a href=\"http://localhost:8080/Rest2Q11/carnet/carnet/" + contact.getNom()
                        + "\">afficher numero du contact</a>";
        }
        // Si le contact n'existe pas, on crée une nouvelle instance de la classe Contact avec le nom et le numéro donnés en paramètre
        Contact newContact = new Contact(name, numero);
        // On ajoute le nouveau contact à la liste des contacts
        CARNET.ajtContact(newContact);
        // On retourne un lien pour afficher le numéro de téléphone du nouveau contact
        return "<a href=\"http://localhost:8080/Rest2Q11/carnet/carnet/" + newContact.getNom()
                + "\">afficher numero du contact</a> <b>" + newContact.getNom() + "</b>" ;
    }


	@Path("/ajouterContactObjet") // L'annotation @Path indique l'URI de la ressource
	@POST // L'annotation @POST spécifie le type de méthode HTTP utilisée pour accéder à la ressource
	@Consumes(MediaType.APPLICATION_XML) // L'annotation @Consumes indique le type MIME des données que la méthode peut accepter en entrée
	@Produces("text/plain") // L'annotation @Produces indique le type MIME des données que la méthode renvoie en sortie
	public String ajouterContactObjet(Contact contact){ // Définition de la méthode avec un objet Contact en entrée

	    String res = CARNET.ajouterContactObjet(contact); // Appel d'une méthode de la classe CARNET pour ajouter le contact au carnet d'adresses

	    System.out.println(res); // Affichage d'un message dans la console

	    return res; // Renvoie le message d'ajout du contact sous forme de chaîne de caractères
	}

	@Path("/update")
	@PUT
	@Produces("text/plain")
	@Consumes(MediaType.APPLICATION_XML)
	public Response updateContact(Contact newContact) {

		// Vérifier si la liste de contacts est vide
		if (CARNET.getContacts().size() == 0) {
			return Response.noContent().build(); // Retourner une réponse indiquant qu'il n'y a pas de contenu
		}

		// Parcourir tous les contacts de la liste
		for (Contact contact : CARNET.getContacts()) {
			if (contact.getNom().equals(newContact.getNom())) { // Si le nom du contact correspond au nouveau contact
				contact.setNumero(newContact.getNumero()); // Modifier le numéro de téléphone du contact
				return Response.created(null).entity("Contact ... modifié").build(); // Retourner une réponse indiquant que le contact a été modifié avec succès
			}
		}

		return Response.noContent().build(); // Retourner une réponse indiquant qu'aucun contact n'a été modifié
	}



	@Path("/delete/{name}")
	@DELETE
	@Produces("text/plain")
	@Consumes("text/plain")
	public String deleteContact(@PathParam("name")String name){

		// Boucle à travers la liste de contacts du carnet
		for(Contact contact : CARNET.getContacts()){
			
			// Si le nom du contact correspond à celui fourni en paramètre de l'URL
			if(contact.getNom().equalsIgnoreCase(name)){
				
				// Supprimer le contact de la liste
				CARNET.getContacts().remove(contact);
				
				// Retourner un message confirmant la suppression du contact et affichant la liste mise à jour
				return "Contact ... supprimé \n"+CARNET.toString();
			}
		}
		
		// Si aucun contact correspondant au nom fourni en paramètre n'a été trouvé, retourner un message d'erreur
		return "Contact ...introuvable !";
	}




/*Question 10*/ 
	@Path("/carnet10/{name}")
	@GET
	@Produces("text/html")
	public String getContactNum(@PathParam("name") String name) {
	// On parcourt la liste de contacts du carnet
	for (Contact contact : CARNET.getContacts()) {
	// Si le nom du contact correspond à celui fourni en paramètre
	if (contact.getNom().equals(name)) {
	// On renvoie son numéro de téléphone
	return contact.getNumero();
	}
	}
	// Si aucun contact n'a été trouvé, on renvoie une exception ContactNotFoundException
	throw new ContactNotFoundException();
	}



	


	/*Question 11*/ 
	@GET
	@Path("supp/{nom}")
	@Produces("text/html")
	public Response suppByName(@PathParam("nom") String nom) throws ContactNotFoundException
	{
	    // Boucle sur la liste des contacts pour trouver le contact avec le nom spécifié
	    for(Contact contact : CARNET.getContacts()){
	        if(contact.getNom().equals(nom))
	        {
	            // Si le contact est trouvé, il est supprimé de la liste des contacts
	            CARNET.getContacts().remove(contact);
	            
	            // Création d'un nouveau cookie avec le nom du contact supprimé
	            NewCookie newCookie = new NewCookie("contact", contact.getNom(), "/Rest2Q11/carnet/", null, 1, null, 500000, false);
	            
	            // Retourne une réponse HTTP 200 (OK) avec un message de confirmation et le cookie créé
	            return Response.ok("Le contact " + nom + " a ete supprime")
	                .cookie(newCookie)
	                .build();
	        }
	    }
	    // Si le contact n'est pas trouvé, une exception est lancée avec un message d'erreur
	    return (new ContactNotFoundException()).getResponse();
	}

	

	/**
	 * Renvoie la dernière valeur du cookie "contact".
	 * @param value la valeur du cookie "contact".
	 * @return la réponse HTTP contenant la dernière valeur du cookie.
	 */
	@Path("/dernier")
	@GET
	@Produces("text/html")
	public Response dernier(@CookieParam("contact") String value) {
	    // Construit la réponse HTTP contenant la dernière valeur du cookie.
	    return Response.status(Response.Status.OK)
	            .entity("Cookie de  <b>" + value + "</b> est le dernier Cookie supprime ... !")
	            .build();
	}





 	@Context
    HttpHeaders httpHeaders;

    /**

	Cette méthode permet de récupérer tous les cookies de la requête HTTP.
	Elle utilise l'annotation @Context pour injecter l'en-tête de la requête dans l'objet HttpHeaders.
	@return une chaîne de caractères contenant la liste de tous les cookies de la requête HTTP.
	*/
	@Path("/listCookies")
	@GET
	public String getCookies() {
	// On récupère les cookies de la requête HTTP
	Map<String, Cookie> cookies = httpHeaders.getCookies();
	if (cookies.isEmpty()) {
            return "No cookies found.";
        } else {
            StringBuilder sb = new StringBuilder();
            for (Map.Entry<String, Cookie> entry : cookies.entrySet()) {
                sb.append(entry.getKey()).append("=");
                sb.append(entry.getValue().getValue()).append("; ");
            }
            return sb.toString();
        }
    }
}




