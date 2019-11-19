using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrapiApi.DataLayer.DTO
{
    public class UserRegisterDTO
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4,ErrorMessage ="Length 4 and 8")]
        public string Password { get; set; }

    }
}
