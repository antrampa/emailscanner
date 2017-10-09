using scanner.Contexts;
using scanner.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using scanner.Contexts;
using System.Data.Entity.Migrations;

namespace scanner.Daos
{
    public class EMailsDao
    {
        #region Fields
        //private static Logger _logger = LogManager.GetCurrentClassLogger();
        #endregion

        #region Constructor
        public EMailsDao() //: base()
        {
        }
        //internal static H1TExtsDao Instance
        //{
        //    get { return ThreadSingleton<H1TExtsDao>.Instance; }
        //}
        #endregion

        #region Methods 
        public void Add(EMail eMail)
        {
            try
            {
                using (var db = new MainContext())
                {
                    //db.H1Texts.AddOrUpdate(i => i.Text, h1Text);
                    db.EMails.Add(eMail);
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
