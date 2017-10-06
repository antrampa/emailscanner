using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scanner.Controllers
{
    public class WriterController : IWriterController
    {
        public bool WriteEmails(IList<string> emails)
        {
            try
            {
                var path = @"emails.csv";
                if (!System.IO.File.Exists(path))
                {
                    // Create a file to write to.
                    System.IO.File.WriteAllLines(path, emails);
                }
                else
                {
                    System.IO.File.AppendAllLines(path, emails);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool WriteH1(IList<string> h1Texts)
        {
            try
            {
                var path = @"h1Texts.csv";
                if (!System.IO.File.Exists(path))
                {
                    // Create a file to write to.
                    System.IO.File.WriteAllLines(path, h1Texts);
                }
                else
                {
                    System.IO.File.AppendAllLines(path, h1Texts);
                }
                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool WriteLinks(IList<string> links)
        {
            try
            {
                var path = @"links.csv";
                if (!System.IO.File.Exists(path))
                {
                    // Create a file to write to.
                    System.IO.File.WriteAllLines(path, links);
                }
                else
                {
                    System.IO.File.AppendAllLines(path, links);
                }
               
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            

        }
    }
}
