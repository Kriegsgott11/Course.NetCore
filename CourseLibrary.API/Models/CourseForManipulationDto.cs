using CourseLibrary.API.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Models
{
    [CourseTitleMustBeDifferentFromDescriptionAttribute(ErrorMessage = "El titulo debe ser diferende de la descripcion.")]
    public abstract class CourseForManipulationDto
    {
        [Required(ErrorMessage = "You shuld fill out a title.")] //Indica que este campo es obligatorio
        [MaxLength(100, ErrorMessage = "The title shouldn't have more than 100 characters.")] //indica el tamaño maximo del campo.
        public string Title { get; set; }

        [MaxLength(1500, ErrorMessage = "The description shouldn't have more than 1500 characters.")]
        public virtual string Description { get; set; }
    }
}
