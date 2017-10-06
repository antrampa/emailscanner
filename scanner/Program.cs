﻿using scanner.Controllers;
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
            IReaderController reader = new ReaderController();
            IWebScannerController scaner = new WebScannerController();
            IWriterController writerController = new WriterController();

            var savedLinks = reader.ReadLinks();
            foreach(var savedLink in savedLinks)
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
