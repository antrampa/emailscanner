using scanner.Contexts;
using scanner.Controllers;
using scanner.Daos;
using scanner.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scanner
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                IReaderController reader = new ReaderController();
                IWebScannerController scaner = new WebScannerController();
                IWriterController writerController = new WriterController();

                var db = new MainContext();

                var savedLinks = reader.ReadLinksFromDB(); // reader.ReadLinks();
                var linkDao = new LinksDao();
                foreach (var savedLink in savedLinks)
                {
                    Console.WriteLine(savedLink);

                    var links = scaner.FindLinks(savedLink, savedLink);


                    writerController.WriteLinks(links);

                    //TODO - Read new links 

                    //TODO Mails
                    var mails = scaner.FindMails(savedLink, savedLink);
                    writerController.WriteEmails(mails);

                    foreach (var link in links)
                    {
                        mails = scaner.FindMails(link, "");
                        writerController.WriteEmails(mails);
                    }


                    ////TODO H1
                    //var h1Texts = scaner.FindH1(savedLink, savedLink);
                    //writerController.WriteH1(h1Texts);

                    //foreach (var link in links)
                    //{
                    //    h1Texts = scaner.FindH1(link, "");
                    //    writerController.WriteH1(mails);
                    //}

                    //Save Link as Scanned 
                    var scannedLink = new Link(savedLink, true);
                    linkDao.Add(scannedLink);

                }


                //var links = scaner.FindLinks("https://www.xo.gr/dir-az/A/Antallaktika-Aftokiniton-Eidi-kai-Axesouar/", "https://www.xo.gr");


                //writerController.WriteLinks(links);

                ////TODO - Read new links 

                ////TODO Mails
                //var mails = scaner.FindMails("https://www.xo.gr/dir-az/A/Antallaktika-Aftokiniton-Eidi-kai-Axesouar/", "https://www.xo.gr");
                //writerController.WriteEmails(mails);

                //foreach(var link in links)
                //{
                //    mails = scaner.FindMails(link, "");
                //    writerController.WriteEmails(mails);
                //}
            }
        }
    }
}
