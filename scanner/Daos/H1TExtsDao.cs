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
    public class H1TExtsDao
    {
        #region Fields
        //private static Logger _logger = LogManager.GetCurrentClassLogger();
        #endregion

        #region Constructor
        public H1TExtsDao() //: base()
        {
        }
        //internal static H1TExtsDao Instance
        //{
        //    get { return ThreadSingleton<H1TExtsDao>.Instance; }
        //}
        #endregion

        #region Methods 
        public void Add(H1Text h1Text)
        {
            try
            {
                using (var db = new MainContext())
                {
                    //db.H1Texts.AddOrUpdate(i => i.Text, h1Text);
                    if(h1Text != null && !db.H1Texts.Any(i=> i.Text == h1Text.Text && i.Url == h1Text.Url ))
                    {
                        db.H1Texts.Add(h1Text);
                        db.SaveChanges();
                    }
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
