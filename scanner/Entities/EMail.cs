using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scanner.Entities
{
    [Table("EMAILS")]
    public class EMail
    {
        #region Properties
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { set; get; }

        //public string Tag { set; get; }
        [Column("URL", TypeName = "NVARCHAR")]
        [StringLength(150)]
        public string Url { set; get; }

        [Column("EMAIL", TypeName = "NVARCHAR")]
        [StringLength(255)]
        [Index]
        public string Email { set; get; }

        #endregion

        #region Constructors 

        public EMail()
        {

        }

        public EMail(string url, string email)
        {
            Url = url;
            Email = email;
        }

        #endregion

    }
}
