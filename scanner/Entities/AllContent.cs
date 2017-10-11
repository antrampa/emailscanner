using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scanner.Entities
{

    [Table("ALL_CONTENT")]
    public class AllContent
    {
        #region Properties
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { set; get; }

        //public string Tag { set; get; }
        [Column("CONTENT", TypeName = "NVARCHAR")]
        public string Content { set; get; }

        #endregion
    }
}
