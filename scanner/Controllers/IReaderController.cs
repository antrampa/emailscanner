using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scanner.Controllers
{
    interface IReaderController
    {
        IList<string> ReadLinks();
        IList<string> ReadEMails();
        IList<string> ReadH1Texts();

    }
}
