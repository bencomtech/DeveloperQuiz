using DeveloperQuiz.Entities;
using EntityFrameworkMock;
using System;
using System.Collections.Generic;

namespace DeveloperQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz1 quiz1 = new Quiz1();
            bool isOverlapped = quiz1.IsOverlapped("20190101", "20190201", "20190131", "20190301");
            bool isNotOverlapped = quiz1.IsOverlapped("20190101", "20190201", "20190201", "20190301");

            Quiz2 quiz2 = new Quiz2();
            List<int> values = new List<int>() { -10, -2, 0, 1, -12, -1, 18 };
            Tuple<int, int> maxValues = quiz2.GetMaxTwo(values);

            HengEntities hengEntities = GetHengEntities();
            Quiz3 quiz3 = new Quiz3(hengEntities);

            try
            {
                List<Contract> contracts = quiz3.GetContracts(2, 3);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private static HengEntities GetHengEntities()
        {
            List<Contract> contracts = new List<Contract>()
            {
                new Contract() { ContractID = 1, ContractDate = new DateTime(2019, 1, 1), ContractCostAmount = 100000 },
                new Contract() { ContractID = 2, ContractDate = new DateTime(2019, 1, 2), ContractCostAmount = 200000 },
                new Contract() { ContractID = 3, ContractDate = new DateTime(2018, 12, 5), ContractCostAmount = 400000 }
            };

            var contextMock = new DbContextMock<HengEntities>("connectionstring");
            var contractDbSetMock = contextMock.CreateDbSetMock(x => x.Contracts, contracts);

            return contextMock.Object;
        }
    }
}
