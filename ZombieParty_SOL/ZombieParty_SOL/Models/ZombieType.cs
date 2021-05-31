﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieParty_SOL.Models
{
  public class ZombieType
  {
    public int Id { get; set; }
    [DisplayName("Type Name")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Type Name have to be fill.")]
    public string TypeName { get; set; }
  }
}
