using System.ComponentModel.DataAnnotations;

namespace DotNet_Bookstore.Models
{
    public class Category
    {
        //pk should always be named Id or <classname>Id e.g. CategoryId
        [Display(Name = "Category ID")]
        [Range(1, 9999999)]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "A customized error message")]
        public string Name { get; set; }
    }
}
