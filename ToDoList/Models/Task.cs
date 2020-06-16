using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Display(Name = "Название")]
        public string Name { get; set; }
        
        [Display(Name = "Описание")]
        public string Description { get; set; }
        
        [Display(Name = "Начало")]
        public DateTime StartDate { get; set; }
        
        [Display(Name = "Дата завершения")]
        public DateTime EndDate { get; set; }
        
        [Display(Name = "Дата создания")]
        public DateTime CreationDate { get; set; }
    }
}