using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
          //var student = new Student("Cássio", "Gamarra", "02215301007", "cassio.gamarra@compasso.com.br");
          var name = new Name("Teste", "Teste");
        }
    }
}
;