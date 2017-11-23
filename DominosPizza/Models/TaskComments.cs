using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DominosPizza.Models
{
    public class TaskComments

    {
        public int TaskCommentsId { get; set; } 
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public DateTime CommentTime { get; set; }
        public string CommentText { get; set; } 
    }
}