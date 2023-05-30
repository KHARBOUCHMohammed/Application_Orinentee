package mohammed ;
import java.util.ArrayList;
import java.util.List;
import javax.ws.rs.* ;
import java.lang.*;
import java.util.*;


public class Carnet{
  
  private List<Contact> contacts ; 
  
  public Carnet(){
    this.contacts = new ArrayList<Contact>();
    
    this.contacts.add(new Contact("Mohammed","0633575104"));
    this.contacts.add(new Contact("Kharbouch","0758430637"));

  }
  
  public List<Contact> getContacts(){
    return this.contacts ; 
  }
  public void setContacts(List<Contact> contacts ){
     this.contacts = contacts  ; 
  }

  public void addContact(Contact c){
    this.contacts.add(c);
  }
  
  public String toString(){
    String cncts = "";
    for(Contact contact : contacts){
        cncts+= contact.toString();
    }
    return cncts ; 
  }
  
}
