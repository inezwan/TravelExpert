﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace travelExpert.Models
{
    public partial class Package
    {
        public Package()
        {
            Bookings = new HashSet<Booking>();
            PackagesProductsSuppliers = new HashSet<PackagesProductsSupplier>();
        }

        [Key]
        public int PackageId { get; set; }
        [Required]
        [StringLength(50)]
        public string PkgName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PkgStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PkgEndDate { get; set; }
        [StringLength(50)]
        public string PkgDesc { get; set; }
        [Column(TypeName = "money")]
        public decimal PkgBasePrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? PkgAgencyCommission { get; set; }

        [InverseProperty(nameof(Booking.Package))]
        public virtual ICollection<Booking> Bookings { get; set; }
        [InverseProperty(nameof(PackagesProductsSupplier.Package))]
        public virtual ICollection<PackagesProductsSupplier> PackagesProductsSuppliers { get; set; }
        public override string ToString()
        {
            return PackageId.ToString().PadRight(5) + PkgName.PadRight(20) + PkgDesc.PadRight(50) + PkgStartDate.ToString().PadRight(25) + PkgEndDate.ToString().PadRight(25)
                + PkgBasePrice.ToString("C2").PadRight(15) + PkgAgencyCommission.ToString().PadRight(5);
        }

    }
}
