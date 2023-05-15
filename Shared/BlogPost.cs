using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Blog.Shared
{
    //    "internal" olarak işaretlenen bir üye, yalnızca aynı derleme birimindeki diğer kodlar tarafından erişilebilir ve 
    //    dışarıdan erişilemez.


    public class BlogPost
    {
      //[JsonIgnore] =>  JSON çıktısında bu özellik yer almaz.

       [JsonIgnore]
        public int Id { get; set; }
        //[Required] => bu alanın boş geçilemez olduğunu ve değer içermesi gerektiğini belirtmek için kullanılan bir niteliktir.

        [Required(ErrorMessage = "Url is required"), StringLength(100, ErrorMessage = "Maximum length must be around 100")]
        public string Url { get; set; } = string.Empty;
        [Required(ErrorMessage = "Title is required"), StringLength(100, ErrorMessage = "Maximum length must be around 100")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Content is required")]
        public string Content { get; set; } = string.Empty;
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = string.Empty;
        public string? Author { get; set; }
        public string? Image { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public bool IsPublished { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
