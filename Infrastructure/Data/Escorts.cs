﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Infrastructure.Data;

public partial class Escorts
{
    public int EscortId { get; set; }

    public string FullName { get; set; }

    public bool IsAdult { get; set; }

    public int ReservationId { get; set; }

    public virtual Reservations Reservation { get; set; }
}