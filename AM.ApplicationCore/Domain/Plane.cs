﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        [Range(50, 500, ErrorMessage = "La capacité doit être comprise entre 50 et 500.")]
        public int Capacity { get; set; }
        [DataType(DataType.Date, ErrorMessage = "La date de fabrication doit contenir uniquement des informations sur le jour, le mois et l'année.")]
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public IList<Flight> Flights { get; set; }
        public Plane()
        {}
        public Plane(PlaneType planeType, int capacity, DateTime manufactureDate)
        {
            PlaneType = planeType;
            Capacity = capacity;
            ManufactureDate = manufactureDate;
        }
        public override string ToString()
        {
            return $"PlaneId : {PlaneId}, PlaneType : {PlaneType}";
        }
    }
}
