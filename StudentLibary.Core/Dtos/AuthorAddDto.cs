using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Core.Dtos
{
    public class AuthorAddDto
    {
        [DisplayName("Yazar Adı")]
        [Required(ErrorMessage ="{0} boş geçilemez")]
        [MaxLength(50,ErrorMessage ="{0} {1} karakterden büyük olamaz")]
        [MinLength(1,ErrorMessage ="{0} {1} karakterden az olamaz")]
        public string Name { get; set; }
        [DisplayName("Yazar Soyadı")]
        [Required(ErrorMessage = "{0} boş geçilemez")]
        [MaxLength(50, ErrorMessage = "{0} {1} karakterden büyük olamaz")]
        [MinLength(1, ErrorMessage = "{0} {1} karakterden az olamaz")]
        public string Surname { get; set; }
        
    }
}
