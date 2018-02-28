using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SportsNews.Models
{
    [Table("Subscriptions")]
    public class Subscriptions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="SubscriptionID")]
        public string SubID { get; set; }
        [Display(Name ="Subscription Name")]
        public string SubName { get; set; }
        [Display(Name ="Description")]
        public string Description { get; set; }
        [Display(Name ="Category")]
        public string Category { get; set; }
        [Display(Name ="Language")]
        public string Language { get; set; }
        [Display(Name ="Country")]
        public string Country { get; set; }

    }
}