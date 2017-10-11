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
                    if(link != null && !db.Links.Any(i=>i.Url == link.Url))
                    {
                        db.Links.AddOrUpdate(i => i.Url, link);
                        db.SaveChanges();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SetScanned(Link link, bool hasScanned)
        {
            try
            {
                if (link != null)
                {
                    link.HasScanned = hasScanned;
                }
                
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

        public IList<string> GetUnreadedLinks()
        {
            IList<string> links;
            try
            {
                using (var db = new MainContext())
                {
                    links = db.Links.Where(l => l.HasScanned == false || l.HasScanned == null).OrderBy(p=>p.Sort).OrderBy(p => p.Weight).Select(l=>l.Url).ToList();                    
                }
                return links;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion
    }
}
