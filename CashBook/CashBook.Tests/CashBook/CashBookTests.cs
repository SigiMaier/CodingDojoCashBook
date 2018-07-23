// <copyright file="CashBookTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CashBook.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// TestClass for Testing the CashBook Class
    /// </summary>
    [TestClass]
    public class CashBookTests
    {
        private const string CREATENEWCASHBOOKFILE
            = @"D:\3_Dev\CodingDojo\ApplicationKata\CashBook\TestFiles\CreateNewCashBookTestFile.xml";
        private const string GETCASHBOOKTESTFILE
            = @"D:\3_Dev\CodingDojo\ApplicationKata\CashBook\TestFiles\TransactionFileForGetCashBookPageTest.txt";

        /// <summary>
        /// Scenario under test: Creating a new CashBook when no CashBook-File exists
        /// <i>Given</i> No Cashbook file exists,
        /// <i>when</i> instantiating a new CashBook item,
        /// <i>then</i> a new file is created and afterwards deleted
        /// </summary>
        [TestMethod]
        public void CreateNewCashBook_NoCashBookExists_FileIsCreated()
        {
            // Arrange
            if (File.Exists(CREATENEWCASHBOOKFILE))
            {
                File.Delete(CREATENEWCASHBOOKFILE);
            }

            // Act
            Contracts.ICashBook cashBook = new CashBook(CREATENEWCASHBOOKFILE);

            // Assert
            Assert.IsTrue(
                File.Exists(CREATENEWCASHBOOKFILE),
                "After instantiating a new CashBook object a CreateNewCashBookTestFile.xml has to exist");
        }

        //[TestMethod]
        //public void GetCashBookPage_FileExistsContainingRequiredData_TheListOfTransactionsIsNotEmpty()
        //{
        //    // Arrange
        //    Contracts.ICashBook cashBook = new CashBook();

        //    // Act
        //    List<Transaction> transactions = cashBook.Get
        //}
    }
}
