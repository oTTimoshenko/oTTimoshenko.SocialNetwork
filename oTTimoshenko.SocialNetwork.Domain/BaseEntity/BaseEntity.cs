using System.ComponentModel.DataAnnotations;

namespace oTTimoshenko.SocialNetwork.Domain
{
    public abstract class BaseEntity: IBaseEntity
    {
        public int Id { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
