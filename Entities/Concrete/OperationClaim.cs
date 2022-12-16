using Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Core.Entities.Concrete
{
    public class OperationClaim:IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OperationClaimId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string OperationClaimName { get; set; }

        [JsonIgnore]
        [DataMember]
        public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
