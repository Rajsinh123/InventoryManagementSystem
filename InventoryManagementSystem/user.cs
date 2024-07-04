//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class user
    {
        [Key]
        public int u_id { get; set; }
        [Display(Name ="Name")]
        [Required(ErrorMessage ="Pls Enter the Name")]
        public string u_name { get; set; }
        [Display(Name = "User name")]
        [Required(ErrorMessage = "Pls Enter the UserName")]
        public string u_username { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Pls Enter the Password")]
        [DataType(DataType.Password)]
        public string u_password { get; set; }
        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Pls Enter the Phonenumber")]
        public string u_phone { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Pls Enter the Email")]
        public string u_email { get; set; }
        [Display(Name = "Status")]
        [Required(ErrorMessage = "Pls Enter the Status")]
        public byte u_status { get; set; }
        [Display(Name = "Role")]
        [Required(ErrorMessage = "Pls Enter the Role")]
        public byte u_roleID { get; set; }
       

        public virtual role role { get; set; }
    }
}
