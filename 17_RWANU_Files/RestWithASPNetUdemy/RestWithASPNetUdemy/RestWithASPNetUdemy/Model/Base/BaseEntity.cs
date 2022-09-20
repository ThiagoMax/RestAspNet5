using System.ComponentModel.DataAnnotations.Schema;

namespace RWANU.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
