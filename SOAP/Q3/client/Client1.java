import java.net.URL;
import java.net.URL;
import javax.xml.namespace.QName;
import javax.xml.ws.Service;
import javax.xml.namespace.QName;
import localhost._8080.*;

public class Client1{
	static SalutService service = new SalutService();
	public static void main(String[] args) throws Exception {
		
		ISalut Soap = service.getPort(ISalut.class);
		System.out.println(Soap.salut("Kharbouch"));
	}
}