/*package mohammed;

import java.lang.*;
import java.util.*;

public class Contact {

	private String nom;
	private String numero;

	public Contact(String nom, String numero) {
		this.nom = nom;
		this.numero = numero;
	}

	public String getNumero() {
		return this.numero;
	}

	public String getNom() {
		return this.nom;
	}

	public void setNumero(String numero) {
		this.numero = numero;
	}
	public void setNom(String nom) {
		this.nom = nom;
	}

	public String toString() {
		return "* Nom : <b>" + this.getNom()+"</b>\n * Numero : <b>" + this.getNumero()+ "</b> \n <br><br>";
	}
}*/



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