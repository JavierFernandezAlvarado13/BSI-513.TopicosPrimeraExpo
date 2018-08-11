using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrimeraExpo.ViewModels.PersonaViewModels
{
    public class RegistrarViewModel
    {
        //Nombre
        [Required(ErrorMessage = "Ingrese el nombre completo")]
        [Display(Name = "Nombre")]
        [MinLength(2, ErrorMessage = "El nombre debe contener más de 2 caracteres")]
        [MaxLength(100, ErrorMessage = "El nombre no puede contener más de 50 caracteres")]
        public string Nombre { get; set; }

        //Apellidos
        [Required(ErrorMessage = "Ingrese el nombre completo")]
        [Display(Name = "Apellidos")]
        [MinLength(2, ErrorMessage = "El nombre debe contener más de 2 caracteres")]
        [MaxLength(100, ErrorMessage = "El nombre no puede contener más de 50 caracteres")]
        public string Apellidos { get; set; }

        //Edad
        [Required]
        [Range(18, 120, ErrorMessage = "La edad debe ser entre 18 y 120 años" )]
        [Display(Name = "Edad")]
        public int Edad { get; set; }

        //Correo
        [Required(ErrorMessage = "Ingrese el correo electrónico")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Correo electrónico")]
        [MinLength(7, ErrorMessage = "El correo electrónico debe contener más de 7 caracteres")]
        [MaxLength(100, ErrorMessage = "El correo electrónicon no puede contener más de 100 caracteres")]
        [RegularExpression(@"^(([^<>()\[\]\\.,;:\s@""]+(\.[^<>()\[\]\\.,;:\s@""]+)*)|("".+""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$", ErrorMessage = "El correo no es válido")]
        public string Correo { get; set; }

        //Contraseñas
        [Required(ErrorMessage = "La contraseña es requerida")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        [MinLength(8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres")]
        [MaxLength(40, ErrorMessage = "La contraseña no puede tener más de 40 caracteres")]
        [RegularExpression(@"^(?=.*\d)(?=.*[A-z])(.*)$", ErrorMessage = "La contraseña debe tener al menos una letra y un número")]
        public string Contrasenna { get; set; }

        [Required(ErrorMessage = "La confirmación de la  contraseña es requerida")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirme la contraseña")]
        [Compare("Contrasenna", ErrorMessage = "Ambas contraseñas deben de ser iguales")]
        public string Confirmacion { get; set; }
    }
}