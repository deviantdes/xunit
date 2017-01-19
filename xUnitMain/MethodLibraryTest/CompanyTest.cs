using System;
using System.Collections.Generic;
using Xunit;
using MethodLibrary;
using Moq;
using Xunit.Extensions;

namespace MethodLibraryTest
{

    public class CompanyTest
    {
        public static IEnumerable<object[]> dataLists
        {
            get
            {
                return new[]{
                    new object[]{ new List<Employee>(){new Employee(){Name="desmond",Age=1,Title="sd"},new Employee(){Name="desmond",Age=1,Title="deV"}}}
                };
            }
        }



        [Theory, MemberData("dataLists")]
        public void hasDevelopers_returnTrue(List<Employee> inlineData)
        {
            Mock<IRepository> mockRepos = new Mock<IRepository>();
            Company c = new Company(mockRepos.Object);

            mockRepos.Setup(x => x.getEmployees()).Returns(inlineData);

            bool hasDev = c.hasDevelopers();

            Assert.Equal(true, hasDev);

        }

        [Fact]
        public void getListofDevelopers_gets2devs()
        {
            Mock<IRepository> mockRepos = new Mock<IRepository>();
            Company c = new Company(mockRepos.Object);

            List<Employee> e = new List<Employee>();
            e.Add(new Employee() { Name = "a", Age = 1, Title = "dev" });
            e.Add(new Employee() { Name = "a", Age = 1, Title = "dev" });

            mockRepos.Setup(x => x.getEmployees()).Returns(e);

            var numberofDevs = c.getListofDevelopers().Count;

            Assert.Equal(2, numberofDevs);

        }
    }
}
