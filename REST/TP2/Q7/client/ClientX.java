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

import java.lang.*;
import javax.ws.rs.client.*;
import javax.ws.rs.core.*;
import org.glassfish.jersey.client.ClientConfig;
import java.util.*;


public class ClientX {

        public static void main(String[] args){

    
            Scanner sc = new Scanner(System.in);
            System.out.println("Merci de bien vouloir saisir le nom :");
            String nom = sc.nextLine();
            System.out.println("Merci de bien vouloir saisir le numéro :");
            String num = sc.nextLine();


      ClientConfig cliConf = new ClientConfig();
      Client clnt = ClientBuilder.newClient(cliConf);


      

      WebTarget wt = clnt.target("http://localhost:8080/Rest2Q7/carnet");

      // Creation de l'objet Contact :
      
      Contact ct = new Contact();
      ct.setNom(nom);
      
     ct.setNumero(num);
     
     // Creation de l'objet Contact :
     


         Response result2 = wt.path("/update").request()
              .put(Entity.entity(ct,MediaType.APPLICATION_XML));
        System.out.println(result2.readEntity(String.class));
    

      System.out.println(result2);



}

}