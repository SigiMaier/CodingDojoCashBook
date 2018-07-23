// <copyright file="CashBook.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CashBook
{
    using global::CashBook.Contracts;
    using System;
    using System.IO;

    public class CashBook : ICashBook
    {
        private readonly string filePath;

        public CashBook()
        {
        }

        public CashBook(string filePath)
        {
            if (filePath?.Length == 0)
            {
                throw new ArgumentNullException(nameof(filePath));
            }
            else
            {
                this.filePath = filePath;
            }

            if (!File.Exists(this.filePath))
            {
                File.Create(filePath);
            }
        }
    }
}
