import java.net.URL;
import javax.xml.namespace.QName;
import javax.xml.ws.*;
import com.dataaccess.webservicesserver.*;

public class Client {
  @WebServiceRef(wsdlLocation = "https://www.dataaccess.com/webservicesserver/textcasing.wso?WSDL")
  private static TextCasing Soap;

  public static void main(String[] args) throws Exception {
    Soap = new  TextCasing();
    TextCasingSoapType s = Soap.getTextCasingSoap();
    System.out.println(s.invertStringCase("mohammed"));
  }
}