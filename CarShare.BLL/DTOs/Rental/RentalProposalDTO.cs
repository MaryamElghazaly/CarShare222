﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CarShare.BLL.DTOs.Rental
{
    public class RentalProposalDTO
    {
        [Required]
        public Guid CarId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public IFormFile LicenseVerificationUrl { get; set; }
    }
}