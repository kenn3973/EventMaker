﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    class Event
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTime DateTime { get; set; }

        public Event(int Id, string Name, string Description, string Place, DateTime Datetime)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Place = Place;
            this.DateTime = Datetime;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Description: {Description}, Place: {Place}, DateTime: {DateTime}"; 
        }

    }
}
