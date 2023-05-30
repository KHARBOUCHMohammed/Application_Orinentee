package mohammed;

import javax.jws.WebService;



@WebService(targetNamespace = "http://localhost:8080" , endpointInterface="mohammed.ISalut")

public class Salut implements ISalut {

            String text = "";
            String varx = "mohammed";


          public String salut (String varx){

                  text = "Bonjour : " + varx;
                return text;

          }


}
