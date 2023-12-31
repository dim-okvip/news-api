﻿namespace CMS.News.DAL.Entities
{
    public class Menu
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public Guid SiteId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public Site Site { get; set; }
        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
