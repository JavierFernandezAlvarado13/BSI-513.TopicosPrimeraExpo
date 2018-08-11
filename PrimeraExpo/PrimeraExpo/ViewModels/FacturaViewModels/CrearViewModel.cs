using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeraExpo.ViewModels.FacturaViewModels
{
    public class CrearViewModel
    {
        [Required]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [Required]
        [Range(1, 99999, ErrorMessage = "Digite un precio válido")]
        [Display(Name = "Precio")]
        public double Precio { get; set; }

        public int PersonaId { get; set; }

        [Display(Name = "Comprador")]
        public List<SelectListItem> ListaItems { get; set; }
    }
}