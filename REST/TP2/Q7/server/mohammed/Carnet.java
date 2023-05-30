package mohammed;

import javax.ws.rs.* ;


import java.lang.*;
import java.util.*;

public class Carnet{
	
	private List<Contact> contacts ; 
	
	public Carnet(){
		this.contacts = new ArrayList<Contact>(2);
		this.contacts.add(new Contact("Mohammed"," 0633575104  "));
		this.contacts.add(new Contact("kharbouch"," 0758430637  "));
		
	}
	
	public List<Contact> getContacts(){
		return this.contacts ; 
	}
	public void setContacts(List<Contact> contacts ){
		 this.contacts = contacts  ; 
	}

// Méthode pour ajouter contact 
	public void ajtContact(Contact c){
		this.contacts.add(c) ; 
	}



	// Méthode pour ajouter contact Objet
public String ajouterContactObjet(Contact contact){

	boolean existe= false;
	String result;

	for (Contact c : this.contacts ) {

		if(c.getNom().equals(contact.getNom()) && c.getNumero().equals(contact.getNumero())){

			existe=true;
			
		}
		
	}

	if (existe==true) {

		result="Contact"+contact.getNom()+" deja existe";
		
	}else{

		this.contacts.add(contact);

		result="Contact :" + contact.getNom()+ "  "+contact.getNumero()+" est cree avec succes ";
	}

	return result;
}
	
	public String toString(){
		String output = new String();
		for(Contact contact : contacts){
			output+= contact.toString();
		}
		return output ; 
	}
	
}