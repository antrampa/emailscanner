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
            var path = @"links.csv";
            string[] readText = System.IO.File.ReadAllLines(path);
            foreach (string s in readText)
            {
                links.Add(s);
            }

            return links;
        }
    }
}
