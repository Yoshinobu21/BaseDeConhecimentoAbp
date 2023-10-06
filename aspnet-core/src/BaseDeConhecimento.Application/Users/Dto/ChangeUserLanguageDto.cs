using System.ComponentModel.DataAnnotations;

namespace BaseDeConhecimento.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}