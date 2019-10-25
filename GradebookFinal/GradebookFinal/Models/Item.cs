using System;

namespace GradebookFinal.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }

        public string schedule { get; set; }
        public string room { get; set; }

        public int studcount { get; set; }
        public int studdropcount { get; set; }
    }
}