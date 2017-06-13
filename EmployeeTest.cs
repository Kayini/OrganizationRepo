using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;


namespace EmployeeServiceTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class EmployeeTest
    {
        private EmployeeService.EmployeeServiceClient client;
        
        [TestMethod]
        public void TestGetArchieveLogsList1()
        {
            List<EmployeeService.ArchieveData> lstLogs;
            EmployeeService.IEmployeeService emp;

            using (EmployeeService.EmployeeServiceClient empService = new EmployeeService.EmployeeServiceClient())
            {
                lstLogs = empService.GetArchieveLogsList().ToList();
            }
            Assert.IsTrue(lstLogs.Count>0);
        }

        [TestMethod]
        public void TestGetArchieveLogsList2()
        {
            List<EmployeeService.ArchieveData> lstLogs;
            EmployeeService.IEmployeeService emp;

            using (EmployeeService.EmployeeServiceClient empService = new EmployeeService.EmployeeServiceClient())
            {
                lstLogs = empService.GetArchieveLogsList().ToList();
            }
            Assert.IsNull(lstLogs);
        }

        [TestMethod]
        public void TestGetArchieveLogsList3()
        {
            List<EmployeeService.ArchieveData> lstLogs;
            EmployeeService.IEmployeeService emp;

            using (EmployeeService.EmployeeServiceClient empService = new EmployeeService.EmployeeServiceClient())
            {
                lstLogs = empService.GetArchieveLogsList().ToList();
            }
            Assert.Equals(lstLogs.Count,3);
        }

        [TestMethod]
        public void TestGetArchieveLogsList4()
        {
            List<EmployeeService.ArchieveData> lstLogs;
            List<EmployeeService.ArchieveData> lstLogsContainer;
            EmployeeService.IEmployeeService emp;

            Mock<emp> mockContainer = new Mock<emp>();
            lstLogsContainer = mockContainer.GetArchieveLogsList();
            using (EmployeeService.EmployeeServiceClient empService = new EmployeeService.EmployeeServiceClient())
            {
                lstLogs = empService.GetArchieveLogsList().ToList();
            }
            Assert.Equals(lstLogs.Count, lstLogsContainer.Count);
        }

        
    }
}
