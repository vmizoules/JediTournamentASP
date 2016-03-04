using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JediWebSiteApplication.Models
{
    public class EntityModel
    {
        /// <summary>
        /// ID du stade.
        /// </summary>
        [Display(Name = "ID")]
        public int ID { get; set; }
    }
}