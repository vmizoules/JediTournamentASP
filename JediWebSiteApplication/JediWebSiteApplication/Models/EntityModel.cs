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
        /// ID de l'entité.
        /// </summary>
        [Display(Name = "ID")]
        public int ID { get; set; }

        public override string ToString()
        {
            return ID.ToString();
        }
    }
}