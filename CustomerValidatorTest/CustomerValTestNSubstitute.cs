using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;
using NSubstitute;
using CustomerValidator;
using NSubstitute.ExceptionExtensions;

namespace CustomerValidatorTest
{
    [TestFixture]
    public class CustomerValTestNSubstitute
    {

        private CustomerVal _customerVal;
        [SetUp]
        public void Setup()
        {
            _customerVal = new CustomerVal();
        }
        [Test] 
        public void Validate_When_age_grather_then_18_Return_true()
        {
            //arrange
            ICusnew customer = Substitute.For<ICusnew>();
            customer.GetAge().Returns(20);

            //act

            var validate = _customerVal.Validate(customer);

            validate.ShouldBeTrue();

        }
        [Test]
        public void Validate_when_age_less_then_18_Return_fail()
        {
            //arrange
            ICusnew customer = Substitute.For<ICusnew>();

            customer.GetAge().Returns(16);

            //act

            var validate = _customerVal.Validate(customer);

            validate.ShouldBeFalse();
        }
        [Test]
        public void Validate_When_cutomer_is_Null_Throw_exception()
        {

            Action action = () => _customerVal.Validate(null);

            action.ShouldThrow<ArgumentNullException>();
        }
        [Test]
        public void Throw_Exception()
        {
            ICusnew customer = Substitute.For<ICusnew>();

            customer.GetAge().Throws<NotSupportedException>();
        }
        [Test]
        public void GetAge_Test_how_many_time_invoke()
        {

            //arrange
            int times = 0;

            ICusnew customer = Substitute.For<ICusnew>();

            customer.GetAge()
                .Returns(20)
                .AndDoes(info => times++);

            //Act
            customer.GetAge();
            customer.GetAge();
            //assert

            times.ShouldBe(2);
        }
        [Test]
        public void Verification()
        {
            var customerValidation = Substitute.For<ICustomerValidator>();

            var customerRepository = new CustomerRepository(customerValidation, _customerVal);

            var customer = Substitute.For<ICusnew>();
            var customer2 = Substitute.For<ICusnew>();

            customer.FirstName = "John";
            customer.GetAge().Returns(20);
            customer2.LastName = "Wacek";
            customer2.FirstName = "Marek";

            customerRepository.Add(customer);
            customerRepository.Add(customer2);

            var cccc = customerValidation.Validate(customer);

            var amount = customerRepository.AllCustomers.Count();

            amount.ShouldBe(1);
        }

        // calculator.Add(1,2).Returns(3);
        // calculator.Add(Arg.Any<int>(), Arg.Is<int>(i => i > 0)).Returns(1);
    }
}
