import java.util.Scanner;
import javax.ws.rs.client.Client;
import javax.ws.rs.client.ClientBuilder;
import javax.ws.rs.client.WebTarget;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;

import java.io.FileWriter;
import java.io.File ;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;
import org.glassfish.jersey.client.ClientConfig;

public class ClientX {

    public static void main(String[] args) {
    


        Scanner sc = new Scanner(System.in);

        ClientConfig config = new ClientConfig();  
        Client client = ClientBuilder.newClient(config);  

       // List<Contact> contacts = new ArrayList<>();

        // boolean continuer = true;
        // while (continuer) {
    System.out.println("Merci de bien vouloir saisir le nom pour generer le XML :");
    String nom = sc.nextLine();

    WebTarget webTarg = client.target("http://localhost:8080/Rest2Q12/carnet/");
    Contact c = webTarg.path("persist/"+nom).request().get(Contact.class) ;

    try {
        JAXBContext context = JAXBContext.newInstance(Contact.class);
        Marshaller marshaller = context.createMarshaller();
        marshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
        marshaller.marshal(c, System.out);
        marshaller.marshal(c, new File("Carnet.xml")); 
    } catch (JAXBException e) {
        e.printStackTrace();
    }

    // System.out.println("Voulez-vous ajouter un autre contact ? (O/N)");
    // String choix = sc.next();
    // if (!choix.equalsIgnoreCase("O")) {
    //     continuer = false;
    // }
 // }
}
}
