using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TDC.UI.Web.Models
{
    public class Sala:Entidade
    {
        [Required(ErrorMessage = "Preencha o Campo Nome da Sala")]
        [StringLength(50,MinimumLength =  2,ErrorMessage = "O Nome da Sala deve possuir de 2 a 50 caracteres")]
       public string Id { get; set; }
        public string Nome { get; set; }

    }

    
}