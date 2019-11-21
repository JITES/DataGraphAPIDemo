using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DataGrapiApi.Common
{
    public static class Utility
    {
        public static void DownloadHTMLPage(string URL)
        {
            WebClient wc = null;
            try
            {
                wc = new WebClient(); //downloading a web page
                var resultData = wc.DownloadString(URL);
            }
            catch (WebException ex) when (ex.Status == WebExceptionStatus.ProtocolError)
            {
                //code specifically for a WebException ProtocolError
            }
            catch (WebException ex) when ((ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.NotFound)
            {
                //code specifically for a WebException NotFound
            }
            catch (WebException ex) when ((ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.InternalServerError)
            {
                //code specifically for a WebException InternalServerError
            } 
            finally
            {
                //call this if exception occurs or not
                wc?.Dispose();
            } 
        }

    }
}
