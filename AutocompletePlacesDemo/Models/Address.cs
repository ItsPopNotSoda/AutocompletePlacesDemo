using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace AddressAutocomplete.Models
{
    public class Address
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public bool IsBillingAddress { get; set; } //true if billing address, false if shipping address

       // [JsonProperty("street_number")]
        [StringLength(10, MinimumLength = 2)]
        [Display(Name = "Street Number")]
        public string StreetNumber { get; set; } //This is a string to accomodate street numbers such as 102C

        [StringLength(20, MinimumLength = 3)]
        [Display(Name = "Street Name")]
        public string StreetName { get; set; }

        [StringLength(15, MinimumLength = 3)]
        [Display(Name = "City")]
        public string City { get; set; }

        [StringLength(10, MinimumLength = 5)]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; } //this is a string to accomodate zipcodes with a dash (e.g. 27613-2234)


        [StringLength(10, MinimumLength = 2)]
        public string State { get; set; } //If I have time make this a drop-down

        [StringLength(20, MinimumLength = 4)]
        [Display(Name = "Country")]
        public string Country { get; set; }


    }
}