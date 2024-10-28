﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ExamProctoringManagement.Data.Models;

public partial class Slot
{
    public string SlotId { get; set; }

    public DateTime? Date { get; set; }

    public TimeOnly? Start { get; set; }

    public TimeOnly? End { get; set; }

    public bool? Status { get; set; }

    public string ExamId { get; set; }

    public virtual Exam Exam { get; set; }

    public virtual ICollection<FormSlot> FormSlots { get; set; } = new List<FormSlot>();

    public virtual ICollection<FormSwap> FormSwapFromSlotNavigations { get; set; } = new List<FormSwap>();

    public virtual ICollection<FormSwap> FormSwapToSlotNavigations { get; set; } = new List<FormSwap>();

    public virtual ICollection<SlotReference> SlotReferences { get; set; } = new List<SlotReference>();
}