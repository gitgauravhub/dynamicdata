using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UsingSOAPRequest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Please Enter Input values..");
            //int a =Convert.ToInt32(Console.ReadLine());
            //int b =Convert.ToInt32(Console.ReadLine());
            obj.InvokeService();
        }
     public void InvokeService()
        {
            HttpWebRequest request = CreateSOAPWebRequest();
            XmlDocument SOAPReqBody = new XmlDocument();

//            SOAPReqBody.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?>
//<soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
//  <soap:Body>
//    <GetALLPLayers xmlns=""http://tempuri.org/"">
//      <UniversityKeyID>" + "6ahgtr78juf33kijhytg90dslwb" + @"</UniversityKeyID>
//      <SportName>" + "Baseball" + @"</SportName>
//      <Category>" + "R" + @"</Category>
//      <sCreateDate>""</sCreateDate>
//      <sChangeDate>" + "02/05/2017" + @"</sChangeDate>
//      <sFrchangeDate>""</sFrchangeDate>
//    </GetALLPLayers>
//  </soap:Body>
//</soap:Envelope>");


            SOAPReqBody.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?>
<soap12:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap12=""http://schemas.xmlsoap.org/soap/envelope/"">
  <soap12:Body>
    <GetALLPLayers xmlns=""http://tempuri.org/"">
      <UniversityKeyID>6ahgtr78juf33kijhytg90dslwb</UniversityKeyID>
      <SportName>Baseball</SportName>
      <Category>R</Category>
      <sCreateDate/>
      <sChangeDate>02/03/2016</sChangeDate>
      <sFrchangeDate/>
    </GetALLPLayers>
  </soap12:Body>
</soap12:Envelope>");


//                 SOAPReqBody.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?>
//<soap12:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap12=""http://schemas.xmlsoap.org/soap/envelope/"">
//  <soap12:Body>
//    <GetallSportsforAUniversity xmlns=""http://tempuri.org/"">
//      <sUniversityKey>6ahgtr78juf33kijhytg90dslwb</sUniversityKey>
//    </GetallSportsforAUniversity>
//  </soap12:Body>
//</soap12:Envelope>");

         

            using (Stream stream = request.GetRequestStream())
            {
                SOAPReqBody.Save(stream);
            }

            try { 
            using (WebResponse Serviceres = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(Serviceres.GetResponseStream()))
                {
                    var ServiceResult = rd.ReadToEnd();
                    Console.WriteLine(ServiceResult);
                    
                    Console.ReadLine();
                }
            }
            }
            catch (WebException webex)
            {
                WebResponse errResp = webex.Response;
                using (Stream respStream = errResp.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(respStream);
                    string text = reader.ReadToEnd();
                }
            }
        }
       
        public HttpWebRequest CreateSOAPWebRequest()
        {
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(@"https://www.frontrush.com/FRAdmissionsWS/AdmissionService.asmx");
            //HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(@"http://localhost:53252/AdmissionService.asmx");
            //Req.Headers.Add(@"SOAP:Action");
            Req.ContentType = "text/xml;charset=\"utf-8\"";
            Req.Accept = "text/xml";
            Req.Method = "POST";
            return Req;
        }
    }
}
