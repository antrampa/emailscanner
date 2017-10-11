using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace scanner.Controllers
{
    public class WebScannerController : IWebScannerController
    {
        public IList<string> FindH1(string url, string baseurl)
        {
            IList<string> h1s = new List<string>();
            try
            {
                HtmlWeb hw = new HtmlWeb();
                HtmlDocument doc = hw.Load(url);
                if(doc != null && doc.DocumentNode != null)
                {
                    int i = 0;
                    while(!doc.DocumentNode.HasChildNodes && i <= 5)
                    {
                        Thread.Sleep(500);
                        i++;
                    }

                    foreach (HtmlNode h1 in doc.DocumentNode.Descendants("h1"))
                    {
                        h1s.Add(h1.InnerText);

                    }
                }
            }
            catch (Exception ex)
            {

            }

            return h1s;
        }

        public IList<string> FindLinks(string url,string baseurl)
        {
            IList<string> links = new List<string>();
            try
            {
                HtmlWeb hw = new HtmlWeb();
                HtmlDocument doc = hw.Load(url);
                foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
                {
                    var attributes = link.Attributes;
                    //links.Add(link.InnerText);
                    var href = link.GetAttributeValue("href", "");
                    if(!string.IsNullOrEmpty(href) && !href.StartsWith("javascript:")
                         && !href.StartsWith("mailto:")
                         && !href.StartsWith("tel:")
                         && !href.StartsWith("#"))
                    {
                        if(!href.StartsWith("http://") && !href.StartsWith("https://"))
                        {
                            links.Add(baseurl + href);
                        }
                        else
                        {
                            links.Add(href);
                        }
                    
                    }
                }
            }
            catch (Exception)
            {

            }

            return links;
        }

        public IList<string> FindMails(string url, string baseurl)
        {
            IList<string> mails = new List<string>();
            try
            {
                HtmlWeb hw = new HtmlWeb();
                HtmlDocument doc = hw.Load(url);
                foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
                {
                    var attributes = link.Attributes;
                    //links.Add(link.InnerText);
                    var mailto = link.GetAttributeValue("href", "");
                    if (mailto.StartsWith("mailto:"))
                    {
                        mails.Add(mailto);
                    }
                }

            }
            catch (Exception)
            {

            }
            
            return mails;
        }
    }
}
