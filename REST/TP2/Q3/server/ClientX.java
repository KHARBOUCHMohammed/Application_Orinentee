import javax.ws.rs.client.*;
import org.glassfish.jersey.client.*;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;

import org.glassfish.jersey.client.*;

import java.lang.*; 
import javax.ws.rs.client.*;
import org.glassfish.jersey.client.*;
import java.util.Scanner;
import javax.ws.rs.core.*;


public class ClientX {

        public static void main(String[] args){

            Scanner sc = new Scanner(System.in);
            System.out.println("Merci de bien vouloir saisir le nom :");
            String nom = sc.nextLine();
            System.out.println("Merci de bien vouloir saisir le numéro :");
            String num = sc.nextLine();

            Form form = new Form();
            form.param("numero", num);
            form.param("name", nom);
            ClientConfig cliConf = new ClientConfig();
            Client clnt = ClientBuilder.newClient(cliConf);
            WebTarget webTarg = clnt.target("http://localhost:8080/Rest2Q3/annuaire");


            Response response = webTarg.path("/ajtContactx")
            .request(MediaType.APPLICATION_FORM_URLENCODED)
            .post(Entity.form(form)) ;

            if (response.getStatus() == 200){
             System.out.println("Response: " + response.readEntity(String.class));
             }else{
                 System.out.println("erreur");
             }

        }

}