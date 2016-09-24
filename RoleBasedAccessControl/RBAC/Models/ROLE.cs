namespace RBACModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mst_Roles")]
    public partial class Role
    {
        public Role()
        {
            Permissions = new HashSet<Permission>();
            Users = new HashSet<User>();
        }

        [Key]
        [Column("Id")]
        public int RoleId { get; set; }

        [Required]
        [Column("Name")]
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public bool IsSuperAdmin { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
