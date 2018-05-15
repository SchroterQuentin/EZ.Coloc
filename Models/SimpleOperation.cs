using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EZ.Coloc.Models
{
    public class SimpleOperation : IOperation
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public string Label { get; set; }
        [Required]
        public float Value { get; set; }
        [Required]
        public OperationType Type { get; set; }

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
    }
}