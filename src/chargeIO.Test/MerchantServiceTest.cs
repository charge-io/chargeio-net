﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ChargeIO;

namespace ChargeIO.Test
{
    [TestFixture]
    public class MerchantServiceTest
    {
        MerchantService merchantService;

        [SetUp]
        public void TestInitialize()
        {
            merchantService = new MerchantService();
        }

        [Test]
        public void TestRenameMerchant()
        {
            Merchant m = merchantService.GetMerchant();
            Assert.IsTrue(m != null);
            Merchant updated = merchantService.UpdateMerchant(new MerchantOptions()
            {
                Name = "the new merchant name",
                ContactName = m.ContactName,
                ContactEmail = m.ContactEmail, 
                ContactPhone = m.ContactPhone,
                Address1 = m.Address1,
                Address2 = m.Address2,
                City = m.City,
                State = m.State,
                PostalCode = m.PostalCode,
                Country = m.Country,
                Timezone = m.Timezone,
                ApiAllowedIpAddressRanges = m.ApiAllowedIpAddressRanges

            });
            Assert.IsTrue(updated.Name == "the new merchant name");
        }
        [Test]
        public void TestRenameAccount()
        {
            Merchant m = merchantService.GetMerchant();
            Account a = m.Accounts[0];
            Assert.IsTrue(a != null);
            Account updated = merchantService.UpdateAccount(a.Id, new AccountOptions()
            {
                Name = "the new account name",
                Primary = a.Primary,
                RequiredCardFields = a.RequiredCardFields,
                CVVPolicy = a.CVVPolicy,
                AVSPolicy = a.AVSPolicy,
                IgnoreAVSFailureIfCVVMatch = a.IgnoreAVSFailureIfCVVMatch
            });
            Assert.IsTrue(updated.Name == "the new account name");
        }

        [Test]
        public void TestRenameBankAccount()
        {
            Merchant m = merchantService.GetMerchant();
            BankAccount a = m.BankAccounts[0];
            Assert.IsTrue(a != null);
            BankAccount updated = merchantService.UpdateBankAccount(a.Id, new BankAccountOptions()
            {
                Name = "the new bank account name",
                Primary = a.Primary,
                RequiredTransferFields = a.RequiredTransferFields
            });
            Assert.IsTrue(updated.Name == "the new bank account name");
        }
    }
}
