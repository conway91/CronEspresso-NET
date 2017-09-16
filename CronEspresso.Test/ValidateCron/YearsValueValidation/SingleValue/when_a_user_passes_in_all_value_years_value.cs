﻿
using CronEspresso.Resources;
using CronEspresso.Utils;
using NUnit.Framework;

namespace CronEspresso.Test.ValidateCron.YearsValueValidation.SingleValue
{
    [TestFixture]
    public class when_a_user_passes_in_all_values_years_value
    {
        private const string CronValue = "* * * * * * *";
        private CronValidationResults _validationResult;

        [SetUp]
        public void SetUp()
        {
            _validationResult = CronHelpers.ValidateCron(CronValue);
        }

        [Test]
        public void it_gives_the_correct_result()
        {
            Assert.IsTrue(_validationResult.IsValidCron);
        }

        [Test]
        public void it_gives_the_correct_validation_message()
        {
            Assert.AreEqual(string.Format(ValidationMessages.ValidExpression, CronValue), _validationResult.ValidationMessage);
        }
    }
}
