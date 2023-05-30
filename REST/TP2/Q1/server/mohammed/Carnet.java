package mohammed;

import javax.ws.rs.* ;


import java.lang.*;
import java.util.*;

public class Carnet{
	
	private List<Contact> contacts ; 
	
	public Carnet(){
		this.contacts = new ArrayList<Contact>(2);
		// this.contacts.add(new Contact("Mohammed","0633575104"));
		// this.contacts.add(new Contact("kharbouch","0758430637"));
		
	}
	
	public List<Contact> getContacts(){
		return this.contacts ; 
	}
	public void setContacts(List<Contact> contacts ){
		 this.contacts = contacts  ; 
	}
	
	public String toString(){
		String output = new String();
		for(Contact contact : contacts){
			output+= contact.toString();
		}
		return output ; 
	}
	
}