using CourseLibrary.API.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Models
{
    [CourseTitleMustBeDifferentFromDescriptionAttribute(ErrorMessage = "El titulo debe ser diferende de la descripcion.")]
    public class CourseForCreationDto //: IValidatableObject
    {
        [Required] //Indica que este campo es obligatorio
        [MaxLength(100)] //indica el tamaño maximo del campo.
        public string Title { get; set; }
        [MaxLength(1500)]
        public string Description { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (Title == Description)
        //    {
        //        yield return new ValidationResult(
        //            "The provided description shuld be diferent from the title.",
        //            new[] { "CourseForCreationDto" });
        //    }
        //}
    }
}
