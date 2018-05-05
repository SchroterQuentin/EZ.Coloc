using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EZ.Coloc.Models
{
    public class PercentUser
    {
        [Key, Required]
        public int Id { get; set; }
        string _userId;
        [Required]
        public string UserId
        {
            get
            {
                if (User != null)
                {
                    return User.UserName;
                }
                return _userId;
            }
            set
            {
                _userId = value;
            }
        }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public float Percent { get; set; }
    }
}