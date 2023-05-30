package mohammed ;

import java.lang.*;
import java.util.*;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement
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
    return "Nom : " + this.getNom()+" numero : " + this.getNumero()+ "<html><body> <br> <br> </body></html>";
  }
}
