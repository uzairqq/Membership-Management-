using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Memberships.Models
{
    [Table("Item")]
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Title { get; set; }

        [MaxLength(2048)]
        public string Description { get; set; }
        [MaxLength(1048)]
        public string Url { get; set; }

        [MaxLength(1048)]
        public string ImageUrl { get; set; }
        [AllowHtml]
        public string Html { get; set; }

        [DefaultValue(0)]
        public int WaitDays { get; set; }

        public string HtmlShort
        {
            get { return Html == null || 
                         Html.Length < 50 ? Html : Html.Substring(0, 50); }//it is readony not to assign any value
        }

        public int  ProductId { get; set; }
        public int  ItemTypeId { get; set; }
        public int  SectionId { get; set; }
        public int  PartId { get; set; }
        public int IsFree { get; set; }
        //these are ID's certain tables
        [DisplayName("Item Types")]
        public ICollection<ItemType> ItemTypes { get; set; }  ///
            //We should avoid ienumarable and list because of lazy loading 
        //should use ICollection of multiple things
        [DisplayName("Sections")]
        public ICollection<Section> Sections { get; set; }

        [DisplayName("Parts")]
        public ICollection<Part> Parts { get; set; }

    }
}