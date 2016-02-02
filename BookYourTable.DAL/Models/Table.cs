﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookYourTable.DAL.Models
{
    public class Table
    {   
        [Key]
        [Column(Order = 0)]
        public int TableID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int RestaurantID { get; set; }

        public int? Capacity { get; set; }
        public int CellNumber { get; set; }

        [StringLength(128)]
        public String Description { get; set; }

        [ForeignKey("RestaurantID")]
        public virtual Restaurant Restaurant { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
