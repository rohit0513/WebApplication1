using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Sockets;
using System.Net;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            TcpClient tcpClient = new TcpClient();
           // tcpClient.Client.Send(System.Text.Encoding.ASCII.GetBytes("telnet www.google.com 80"));
          //  tcpClient.Connect("www.google.com", 80);
            Response.Write("www.google.com" + " : " + tcpClient.Connected.ToString() + "<BR>");

           Response.Write( StringMerge.mergeStrings("HackerRank", "Monday"));
            List<int> no = new List<int>()
            {8,1,3,1,4,5,6,3,2};
            //{1,2,2,3,4,4,4,5,5,6}
           int res = Result.CountNonUnique(no);

            Response.Write("Number of non unique numbers is " + res);

            String str = "abbbaac";
            Response.Write("Max occurring character is " +
                               StringMerge.getMaxOccuringChar(str));
        }
    }
}