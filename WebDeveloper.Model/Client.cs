using System;
using System.ComponentModel.DataAnnotations;
using WebDeveloper.Resources;

namespace WebDeveloper.Model

{
    public class Client
    {
        //agregar dataanotetion
        //no tocar el ID luego se dira el motivo
        [Display(Name = "Client_Id", ResourceType = typeof(Resource))]
        public int ID { get; set; }
        [Display(Name="Client_Name",ResourceType =typeof(Resource))]
        [Required(ErrorMessage ="This field is required")]
        public string Name { get; set; }
        [Display(Name = "Client_LastName",ResourceType =typeof(Resource))]
        [Required(ErrorMessage = "The Last Name is required")]
        public string LastName { get; set; }
        //al cambiar el apellido se da ctrl . para q aparezca la observacion de cambiar
        //esa variable en todo el proyecto.
        //[DataType(DataType.DateTime, ErrorMessage = "Date only")]
        [Display(Name = "Client_DateCreation", ResourceType = typeof(Resource))]
        public DateTime? DateCreation { get; set; }

    }
}
