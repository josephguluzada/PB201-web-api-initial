﻿namespace PB201Initial.Entities
{
    public class Student : BaseEntity
    {
        public int GroupId { get; set; }
        public string FullName { get; set; }
        public double Grade { get; set; }

        public Group Group { get; set; }
    }
}
