using System.ComponentModel.DataAnnotations;

namespace oTTimoshenko.SocialNetwork.Domain
{
    public interface IBaseEntity
    {
        int Id { get; set; }

        [Timestamp]
        byte[] RowVersion { get; set; }
    }
}
