﻿using CronEspresso.NETCore.Resources;
using CronEspresso.NETCore.Utils;
using NUnit.Framework;

namespace CronEspresso.NETCore.Test.ValidateCron.MonthValueValidation.IntCommaSeparated
{
    [TestFixture]
    public class when_a_user_passes_in_a_comma_months_value_with_trailing_comma
    {
        private const string CronValue = "* * * * 1,12, *";
        private CronValidationResults _validationResult;

        [SetUp]
        public void SetUp()
        {
            _validationResult = CronHelpers.ValidateCron(CronValue);
        }

        [Test]
        public void it_gives_the_correct_result()
        {
            Assert.False(_validationResult.IsValidCron);
        }

        [Test]
        public void it_gives_the_correct_validation_message()
        {
            Assert.AreEqual(string.Format(ValidationMessages.InvalidMonth, CronValue), _validationResult.ValidationMessage);
        }
    }
}
