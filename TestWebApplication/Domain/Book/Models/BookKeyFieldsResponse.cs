﻿using System;
using TestWebApplication.Domain.Base;

namespace TestWebApplication.Domain.Book.Models
{
    public class BookKeyFieldsResponse : IKeyFieldsResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
