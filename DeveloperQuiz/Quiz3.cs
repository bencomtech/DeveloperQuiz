using DeveloperQuiz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeveloperQuiz
{
    public class Quiz3
    {
        private readonly HengEntities hengEntities;

        public Quiz3(HengEntities hengEntities)
        {
            this.hengEntities = hengEntities;
        }

        public List<Contract> GetContracts(long beginContractID, long endContractID)
        {
            if (beginContractID <= 0 || endContractID <= 0)
                throw new ArgumentOutOfRangeException();

            return hengEntities.Contracts.OrderByDescending(it => it.ContractDate)
                .Where(it => it.ContractID >= beginContractID)
                .Where(it => it.ContractID <= endContractID)
                .ToList();
        }
    }
}
