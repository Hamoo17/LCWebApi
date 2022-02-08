using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.MealsModels
{
    public partial class Program
    {
        public Program()
        {
            GiftCodePrograms = new HashSet<GiftCodeProgram>();
            Plans = new HashSet<Plan>();
        }

        public int Id { get; set; }
        public int Active { get; set; }
        public string Type { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public string Description { get; set; }
        public string DescriptionAr { get; set; }
        public string Image { get; set; }
        public int OrderNumber { get; set; }
        public string MaxMeals { get; set; }
        public int NoSnacks { get; set; }
        public string ShortcutName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<GiftCodeProgram> GiftCodePrograms { get; set; }
        public virtual ICollection<Plan> Plans { get; set; }
    }
}
