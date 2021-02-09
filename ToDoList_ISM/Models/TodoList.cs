using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList_ISM.Models
{
    public class TodoList
    {
        public int iD { get; set; }
        [Required]
        public string Content { get; set; }
        public bool IsDone { get; set; }
    }
}
