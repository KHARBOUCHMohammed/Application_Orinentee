
import java.net.URL;
import javax.xml.namespace.QName;
import javax.xml.ws.Service;



import localhost._8080.*;

public class Client {

    public static void main(String[] args) throws Exception {

        URL arg1 = new URL("http://localhost:8080/Question2/SalutService?WSDL");

        QName arg2 = new QName("http://localhost:8080", "SalutService");

        Service service = Service.create(arg1, arg2);

        ISalut Soap = service.getPort(ISalut.class);

        String text = Soap.salut("mohammed");
        
        System.out.println(text);
    }

}