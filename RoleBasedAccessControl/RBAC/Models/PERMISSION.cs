namespace RBACModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Mst_Permissions")]
    public partial class Permission
    {
        public Permission()
        {
            Roles = new HashSet<Role>();
        }

        [Key]
        public int PermissionId { get; set; }

        [Required]
        [StringLength(50)]
        public string PermissionDescription { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
