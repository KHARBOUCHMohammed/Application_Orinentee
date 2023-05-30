
package mohammed;
import javax.ws.rs.*;
import javax.xml.bind.annotation.*;
import java.io.Serializable;

@XmlRootElement(name="contact")
public class Contact implements Serializable {


String nom;
String numero;

public Contact(){

}

public Contact(String nom, String numero) {
	
	this.nom=nom;
	this.numero=numero;
}



public String getNom(){
	return this.nom;

}

public String getNumero(){
	return this.numero;
}

@XmlElement(name="nom")
public void setNom(String nom){
	this.nom=nom;
}


@XmlElement(name="numero")
public void setNumero(String numero){
	this.numero=numero;
}

}