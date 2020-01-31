using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PhoneStoreApp.Models
{
    public class Phone
    {
        [Key]
        public int PhoneID { get; set; }
        public string PhoneName { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public int MSRP { get; set; }
        public string ScreenSize { get; set; }
        public DateTime DateReleased { get; set; }
        [ForeignKey("Manufacturer")]
        public int ManufacturerID { get; set; }

        public Phone(int phoneID, string phoneName, int mSRP, string screenSize, DateTime dateReleased, int manufacturerID)
        {
            PhoneID = phoneID;
            PhoneName = phoneName;
            MSRP = mSRP;
            ScreenSize = screenSize;
            DateReleased = dateReleased;
            ManufacturerID = manufacturerID;
        }

        public Phone(string phoneName, int mSRP, DateTime dateReleased, int manufacturerID)
        {
            PhoneName = phoneName;
            MSRP = mSRP;
            DateReleased = dateReleased;
            ManufacturerID = manufacturerID;
        }

        public Phone() { }
    }
}