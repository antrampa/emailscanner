using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scanner.Entities
{
    [Table("LINKS")]
    public class Link
    {
        #region Properties
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { set; get; }

        //public string Tag { set; get; }
        [Column("URL", TypeName = "NVARCHAR")]
        [StringLength(255)]
        public string Url { set; get; }

        [Column("HAS_SCANNED")]
        public bool? HasScanned { set; get; }
        #endregion

        #region Constructors 
        public Link()
        {

        }

        public Link(string url)
        {
            Url = url;
        }
        #endregion
    }
}
