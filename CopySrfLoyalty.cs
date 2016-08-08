using System;
using System.IO;
using System.Threading;
namespace CopySrfLoyalty
{
    public class CopySrfLoyalty
    {
        Logging log;

        public CopySrfLoyalty ()
        {
        }
        bool CheckTime ()
        {
            if (DateTime.Now.Hour == "09")
                return true;
            return false;
        }
        bool CheckVersion ()
        {
            
        }



        void SetLogLevel (int logLevel)
        {
            
        }
            


        void Work ()
        {
            log = new Logging ();
            string clientNamePathVar = TakeValueOfPathVar ("CLIENTNAME");

            while (true) {
                SetLogLevel (int.Parse(TakeValueOfPathVar ("COPY_SRF_LOG_EVENT")));
                Thread.Sleep (1800000);
                if (CheckTime () && CheckVersion ()) {
                    try {
                        File.Copy (@"C:\app\oracle\siebel\siebsrvr\OBJECTS\ENU\siebel_sia.srf", @"C:\Siebel\Client_1\OBJECTS\ENU\siebel_sia_" +
                        clientNamePathVar + ".srf");
                    } catch (Exception ex) {
                        log.Log (ex);
                    } 
                }
            }
        }

    }
}

