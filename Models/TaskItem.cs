using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserAPI.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title {get; set;}
        public string Description {get; set;}
        public bool IsCompleted {get;set;}
        public DateTime CreatedAt {get; set; } = DateTime.Now;
        public string UserId {get; set;}
    }
}