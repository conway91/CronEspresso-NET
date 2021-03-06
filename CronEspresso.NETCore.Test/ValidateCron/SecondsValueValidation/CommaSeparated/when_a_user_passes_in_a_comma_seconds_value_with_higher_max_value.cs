﻿using CronEspresso.NETCore.Resources;
using CronEspresso.NETCore.Utils;
using NUnit.Framework;

namespace CronEspresso.NETCore.Test.ValidateCron.SecondsValueValidation.CommaSeparated
{
    [TestFixture]
    public class when_a_user_passes_in_a_comma_seconds_value_with_higher_max_value
    {
        private const string CronValue = "31,31,60 * * * * *";
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
            Assert.AreEqual(string.Format(ValidationMessages.InvalidSecondsValue, CronValue), _validationResult.ValidationMessage);
        }
    }
}
