using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scanner.Controllers
{
    interface IWebScannerController
    {
        IList<string> FindLinks(string url, string baseurl);
        IList<string> FindMails(string url, string baseurl);
        IList<string> FindH1(string url, string baseurl);
    }
}
