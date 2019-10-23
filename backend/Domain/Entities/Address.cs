using System;
using Domain.Entities.CoreEntities;

namespace Domain.Entities
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public Guid TypeId { get; set; }
        public Country Country { get; set; }
        public Guid CountryId { get; set; }
        public State State { get; set; }
        public Guid StateId { get; set; }
        public string Street { get; set; }
    }
}