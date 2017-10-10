using scanner.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scanner.Controllers
{
    public class ReaderController : IReaderController
    {
        public IList<string> ReadEMails()
        {
            IList<string> emails = new List<string>();
            var path = @"emails.csv";
            string[] readText = System.IO.File.ReadAllLines(path);
            foreach (string s in readText)
            {
                emails.Add(s);
            }

            return emails;
        }

        public IList<string> ReadH1Texts()
        {
            throw new NotImplementedException();
        }

        public IList<string> ReadLinks()
        {
            IList<string> links = new List<string>();
            var path = @"links_origins.csv";
            string[] readText = System.IO.File.ReadAllLines(path);
            foreach (string s in readText)
            {
                links.Add(s);
            }

            return links;
        }

        public IList<string> ReadLinksFromDB()
        {
            var dao = new LinksDao();
            IList<string> links = dao.GetUnreadedLinks();
            
            return links;
        }
    }
}
