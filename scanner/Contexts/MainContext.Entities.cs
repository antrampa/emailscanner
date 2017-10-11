using scanner.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scanner.Contexts
{
    public partial class MainContext
    {
        #region Entities 
        public new virtual DbSet<H1Text> H1Texts { get; set; }
        public new virtual DbSet<EMail> EMails { get; set; }
        public new virtual DbSet<Link> Links { get; set; }
        public new virtual DbSet<AllContent> AllContents { get; set; }
        public new virtual DbSet<AllH1> AllH1s { get; set; }
        public new virtual DbSet<AllP> AllPs { get; set; }

        #endregion
    }
}
