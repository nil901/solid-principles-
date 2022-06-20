using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
   public class SmartTv
    {  
           public virtual string getOTTApplicationList()
        {
            return "Youtube , prime Video";
        }

        public virtual string getwifiConnectedStuatus()
        {
            return "Connected";
        } 

        public virtual string DisplayResulation()
        {
            return "hd"; 
        }  

        
    }

    public class LG_TV_Android : SmartTv
    {
        public override string getOTTApplicationList()
        {
            return "Youtube , prime Video , NETFLIX , BALAJI , ZEE5";
        }

        public override string getwifiConnectedStuatus()
        {
            return " Not Connected";
        }

        public override string DisplayResulation()
        {
            return "fullHD 1080*2080";
        } 


    }

    public class samsung_TV : SmartTv
    {
        public override string getOTTApplicationList()
        {
            throw new NotImplementedException();    
        }


        public override string getwifiConnectedStuatus()
        {
            throw new NotImplementedException();
        }

        public override string DisplayResulation()
        {
            throw new NotImplementedException();
        } 


    }

    public class LiskovPrincipalDemo : IExecute
    {

        public void run()
        {
            SmartTv smartTv = new SmartTv();
            smartTv = new LG_TV_Android();
            string  listOfTTApplication = smartTv.getOTTApplicationList();
            string isWifiConnected = smartTv.getwifiConnectedStuatus();
            string displayResolution = smartTv.DisplayResulation();

            Console.WriteLine("List of OTT platfrom :" + listOfTTApplication); 
            Console.WriteLine("Wifi Connection status:" + isWifiConnected);
            Console.WriteLine("Display Resolution" + displayResolution);
            

        } 



    } 

}
