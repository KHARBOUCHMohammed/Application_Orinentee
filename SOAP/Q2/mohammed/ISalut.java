package mohammed;

import javax.jws.WebService;


@WebService(targetNamespace = "http://localhost:8080")

// interface définit un service web qui prend une entrée de chaîne de caractères et renvoie une sortie de chaîne de caractères.
public interface ISalut {  
      
      public String salut (String text);

}
