using System.ComponentModel.DataAnnotations;

namespace TDC.UI.Web.Models
{
    public class Sala:Entidade
    {

        [Required(ErrorMessage = "Preencha o Campo Nome da Sala")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "O Campo Sala deve ter entre 2 e 30 caracteres")]
        public string Nome { get; set; }

    }

    
}