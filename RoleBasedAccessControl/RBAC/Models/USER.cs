namespace RBACModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mst_UsersLogin")]
    public partial class User
    {
        public User()
        {
            Roles = new HashSet<Role>();
        }

        [Key]
        [Column("Id")]
        public int UserId { get; set; }

        [Required]
        [StringLength(30)]
        public string UserName { get; set; }

        public DateTime? LastModified { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(30)]
        public string Title { get; set; }

        [StringLength(3)]
        public string Initial { get; set; }

        [StringLength(100)]
        public string EMail { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
