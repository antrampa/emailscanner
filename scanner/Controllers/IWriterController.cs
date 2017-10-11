using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scanner.Controllers
{
    interface IWriterController
    {
        bool WriteLinks(IList<string> links);
        bool WriteEmails(IList<string> emails);
        bool WriteH1(IList<string> h1Texts, string url);
    }
}
