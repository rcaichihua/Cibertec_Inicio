﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model

{
    public class Client
    {
        //agregar dataanotetion
        //no tocar el ID luego se dira el motivo
        public int ID { get; set; }
        [Display(Name="First Name")]
        [Required(ErrorMessage ="This field is required")]
        public string Name { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "The Last Name is required")]
        public string LastName { get; set; }
        //al cambiar el apellido se da ctrl . para q aparezca la observacion de cambiar
        //esa variable en todo el proyecto.
        //[DataType(DataType.DateTime, ErrorMessage = "Date only")]
        public DateTime? DateCreation { get; set; }

    }
}
