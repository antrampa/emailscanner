using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scanner.Entities
{
    [Table("H1_TEXTS")]
    public class H1Text
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

        [Column("TEXT", TypeName = "NVARCHAR")]
        [StringLength(255)]
        [Index]
        public string Text { set; get; }

        #endregion
    }
}
