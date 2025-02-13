using Xunit;
using Mastermind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mastermind.Models;

namespace Mastermind.Tests
{
    public class CodeCheckerTests
    {
        [Fact()]
        public void CheckCode_ValidCode_ShouldReturnAllPluses()
        {
            var secretCode = "1234";
            var userCode = "1234";
            var gameOptions = new GameOptions();

            var result = CodeChecker.CheckCode(userCode, secretCode, gameOptions);

            Xunit.Assert.Equal("++++", result );
        }

        [Fact()]
        public void CheckCode_NothingMatches_ShouldReturnEmptyString()
        {
            var secretCode = "1234";
            var userCode = "5678";
            var gameOptions = new GameOptions();

            var result = CodeChecker.CheckCode(userCode, secretCode, gameOptions);

            Xunit.Assert.Equal(String.Empty, result);
        }

        [Fact()]
        public void CheckCode_RepeatedDigitsInProperPlaces_ShouldReturn2Pluses()
        {
            var secretCode = "1337";
            var userCode = "4338";
            var gameOptions = new GameOptions();

            var result = CodeChecker.CheckCode(userCode, secretCode, gameOptions);

            var actualNumberOfPluses = result.Count(x => x == '+');

            Xunit.Assert.Equal(2, actualNumberOfPluses);
        }

        [Fact()]
        public void CheckCode_OneDigitsInProperPlaceAndOneOut_ShouldReturn1PlusAnd1Minus()
        {
            var secretCode = "1337";
            var userCode = "4318";
            var gameOptions = new GameOptions();

            var result = CodeChecker.CheckCode(userCode, secretCode, gameOptions);


            Xunit.Assert.Equal("+-", result);
        }

        [Fact()]
        public void CheckCode_AllDigitsOutOfPlace_ShouldReturnAllMinuses()
        {
            var secretCode = "1234";
            var userCode = "4321";
            var gameOptions = new GameOptions();

            var result = CodeChecker.CheckCode(userCode, secretCode, gameOptions);


            Xunit.Assert.Equal("----", result);
        }


    }
}