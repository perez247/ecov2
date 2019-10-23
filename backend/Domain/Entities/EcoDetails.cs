using System;
using Domain.Entities.CoreEntities;

namespace Domain.Entities
{
    public class EcoDetails
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public Guid TypeId { get; set; }
                
        // Eco Entity 
        public EcoEntity EcoEntity { get; set; }
        public int? EcoEntityId { get; set; }

        // UN SDG Goals
        public UnSDGGoal UnSDGGoal { get; set; }
        public int? UnSDGGoalId { get; set; }
        public string UnSDGGoalsOther { get; set; }

        // ICO
        public Ico Ico { get; set; }
        public int? IcoId { get; set; }
        public string IcoOther { get; set; }
    }
}