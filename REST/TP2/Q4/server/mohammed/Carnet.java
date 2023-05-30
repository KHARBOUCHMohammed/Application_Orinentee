package mohammed;

import javax.ws.rs.* ;


import java.lang.*;
import java.util.*;

public class Carnet{
	
	private List<Contact> contacts ; 
	
	public Carnet(){
		this.contacts = new ArrayList<Contact>(2);
		this.contacts.add(new Contact("Mohammed"," 0633575104 \n "));
		this.contacts.add(new Contact("kharbouch"," 0758430637 \n "));
		
	}
	
	public List<Contact> getContacts(){
		return this.contacts ; 
	}
	public void setContacts(List<Contact> contacts ){
		 this.contacts = contacts  ; 
	}

	public void ajtContact(Contact c){
		this.contacts.add(c) ; 
	}
	
	public String toString(){
		String output = new String();
		for(Contact contact : contacts){
			output+= contact.toString();
		}
		return output ; 
	}
	
}