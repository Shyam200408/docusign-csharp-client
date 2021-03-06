/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using DocuSign.eSign.Api;
using DocuSign.eSign.Model;
using DocuSign.eSign.Client;
using System.Reflection;

namespace DocuSign.eSign.Test
{
    /// <summary>
    ///  Class for testing ConsumerDisclosure
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ConsumerDisclosureTests
    {
        // TODO uncomment below to declare an instance variable for ConsumerDisclosure
        //private ConsumerDisclosure instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ConsumerDisclosure
            //instance = new ConsumerDisclosure();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConsumerDisclosure
        /// </summary>
        [Test]
        public void ConsumerDisclosureInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ConsumerDisclosure
            //Assert.IsInstanceOfType<ConsumerDisclosure> (instance, "variable 'instance' is a ConsumerDisclosure");
        }

        /// <summary>
        /// Test the property 'AccountEsignId'
        /// </summary>
        [Test]
        public void AccountEsignIdTest()
        {
            // TODO unit test for the property 'AccountEsignId'
        }
        /// <summary>
        /// Test the property 'AllowCDWithdraw'
        /// </summary>
        [Test]
        public void AllowCDWithdrawTest()
        {
            // TODO unit test for the property 'AllowCDWithdraw'
        }
        /// <summary>
        /// Test the property 'ChangeEmail'
        /// </summary>
        [Test]
        public void ChangeEmailTest()
        {
            // TODO unit test for the property 'ChangeEmail'
        }
        /// <summary>
        /// Test the property 'ChangeEmailOther'
        /// </summary>
        [Test]
        public void ChangeEmailOtherTest()
        {
            // TODO unit test for the property 'ChangeEmailOther'
        }
        /// <summary>
        /// Test the property 'CompanyName'
        /// </summary>
        [Test]
        public void CompanyNameTest()
        {
            // TODO unit test for the property 'CompanyName'
        }
        /// <summary>
        /// Test the property 'CompanyPhone'
        /// </summary>
        [Test]
        public void CompanyPhoneTest()
        {
            // TODO unit test for the property 'CompanyPhone'
        }
        /// <summary>
        /// Test the property 'CopyCostPerPage'
        /// </summary>
        [Test]
        public void CopyCostPerPageTest()
        {
            // TODO unit test for the property 'CopyCostPerPage'
        }
        /// <summary>
        /// Test the property 'CopyFeeCollectionMethod'
        /// </summary>
        [Test]
        public void CopyFeeCollectionMethodTest()
        {
            // TODO unit test for the property 'CopyFeeCollectionMethod'
        }
        /// <summary>
        /// Test the property 'CopyRequestEmail'
        /// </summary>
        [Test]
        public void CopyRequestEmailTest()
        {
            // TODO unit test for the property 'CopyRequestEmail'
        }
        /// <summary>
        /// Test the property 'Custom'
        /// </summary>
        [Test]
        public void CustomTest()
        {
            // TODO unit test for the property 'Custom'
        }
        /// <summary>
        /// Test the property 'EnableEsign'
        /// </summary>
        [Test]
        public void EnableEsignTest()
        {
            // TODO unit test for the property 'EnableEsign'
        }
        /// <summary>
        /// Test the property 'EsignAgreement'
        /// </summary>
        [Test]
        public void EsignAgreementTest()
        {
            // TODO unit test for the property 'EsignAgreement'
        }
        /// <summary>
        /// Test the property 'EsignText'
        /// </summary>
        [Test]
        public void EsignTextTest()
        {
            // TODO unit test for the property 'EsignText'
        }
        /// <summary>
        /// Test the property 'LanguageCode'
        /// </summary>
        [Test]
        public void LanguageCodeTest()
        {
            // TODO unit test for the property 'LanguageCode'
        }
        /// <summary>
        /// Test the property 'MustAgreeToEsign'
        /// </summary>
        [Test]
        public void MustAgreeToEsignTest()
        {
            // TODO unit test for the property 'MustAgreeToEsign'
        }
        /// <summary>
        /// Test the property 'PdfId'
        /// </summary>
        [Test]
        public void PdfIdTest()
        {
            // TODO unit test for the property 'PdfId'
        }
        /// <summary>
        /// Test the property 'UseBrand'
        /// </summary>
        [Test]
        public void UseBrandTest()
        {
            // TODO unit test for the property 'UseBrand'
        }
        /// <summary>
        /// Test the property 'UseConsumerDisclosureWithinAccount'
        /// </summary>
        [Test]
        public void UseConsumerDisclosureWithinAccountTest()
        {
            // TODO unit test for the property 'UseConsumerDisclosureWithinAccount'
        }
        /// <summary>
        /// Test the property 'WithdrawAddressLine1'
        /// </summary>
        [Test]
        public void WithdrawAddressLine1Test()
        {
            // TODO unit test for the property 'WithdrawAddressLine1'
        }
        /// <summary>
        /// Test the property 'WithdrawAddressLine2'
        /// </summary>
        [Test]
        public void WithdrawAddressLine2Test()
        {
            // TODO unit test for the property 'WithdrawAddressLine2'
        }
        /// <summary>
        /// Test the property 'WithdrawByEmail'
        /// </summary>
        [Test]
        public void WithdrawByEmailTest()
        {
            // TODO unit test for the property 'WithdrawByEmail'
        }
        /// <summary>
        /// Test the property 'WithdrawByMail'
        /// </summary>
        [Test]
        public void WithdrawByMailTest()
        {
            // TODO unit test for the property 'WithdrawByMail'
        }
        /// <summary>
        /// Test the property 'WithdrawByPhone'
        /// </summary>
        [Test]
        public void WithdrawByPhoneTest()
        {
            // TODO unit test for the property 'WithdrawByPhone'
        }
        /// <summary>
        /// Test the property 'WithdrawCity'
        /// </summary>
        [Test]
        public void WithdrawCityTest()
        {
            // TODO unit test for the property 'WithdrawCity'
        }
        /// <summary>
        /// Test the property 'WithdrawConsequences'
        /// </summary>
        [Test]
        public void WithdrawConsequencesTest()
        {
            // TODO unit test for the property 'WithdrawConsequences'
        }
        /// <summary>
        /// Test the property 'WithdrawEmail'
        /// </summary>
        [Test]
        public void WithdrawEmailTest()
        {
            // TODO unit test for the property 'WithdrawEmail'
        }
        /// <summary>
        /// Test the property 'WithdrawOther'
        /// </summary>
        [Test]
        public void WithdrawOtherTest()
        {
            // TODO unit test for the property 'WithdrawOther'
        }
        /// <summary>
        /// Test the property 'WithdrawPhone'
        /// </summary>
        [Test]
        public void WithdrawPhoneTest()
        {
            // TODO unit test for the property 'WithdrawPhone'
        }
        /// <summary>
        /// Test the property 'WithdrawPostalCode'
        /// </summary>
        [Test]
        public void WithdrawPostalCodeTest()
        {
            // TODO unit test for the property 'WithdrawPostalCode'
        }
        /// <summary>
        /// Test the property 'WithdrawState'
        /// </summary>
        [Test]
        public void WithdrawStateTest()
        {
            // TODO unit test for the property 'WithdrawState'
        }

    }

}
