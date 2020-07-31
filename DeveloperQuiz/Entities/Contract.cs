using System;
using System.ComponentModel.DataAnnotations;

namespace DeveloperQuiz.Entities
{
    public class Contract
    {
        [Key]
        public long ContractID { get; set; }
        public DateTime ContractDate { get; set; }
        public decimal ContractCostAmount { get; set; }
    }
}
