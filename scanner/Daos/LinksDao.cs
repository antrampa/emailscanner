using scanner.Contexts;
using scanner.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scanner.Daos
{
    public class LinksDao
    {
        #region Fields
        //private static Logger _logger = LogManager.GetCurrentClassLogger();
        #endregion

        #region Constructor
        public LinksDao() //: base()
        {
        }
        //internal static H1TExtsDao Instance
        //{
        //    get { return ThreadSingleton<H1TExtsDao>.Instance; }
        //}
        #endregion

        #region Methods 
        public void Add(Link link)
        {
            try
            {
                using (var db = new MainContext())
                {
                    db.Links.AddOrUpdate(i => i.Url, link);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion
    }
}
