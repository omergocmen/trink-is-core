using Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Core.Entities.Concrete
{
    public class UserOperationClaim:IEntity
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserOperationClaimId { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        [DataMember]
        [JsonIgnore]
        public virtual User User { get; set; }

        public int OperationClaimId { get; set; }
        [ForeignKey("OperationClaimId")]
        [DataMember]
        [JsonIgnore]
        public virtual OperationClaim OperationClaim { get; set; }

    }
}
