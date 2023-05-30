package mohammed;

import javax.jws.WebService;


@WebService(targetNamespace = "http://localhost:8080")
public interface ISalut {  
      
      public String salut (String text);

}
