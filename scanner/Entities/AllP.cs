using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scanner.Entities
{
    [Table("ALL_P")]
    public class AllP
    {
        #region Properties
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { set; get; }

        //public string Tag { set; get; }
        [Column("ALL_P", TypeName = "NVARCHAR")]
        public string All_P { set; get; }

        #endregion
    }
}
