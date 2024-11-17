﻿using System;
using System.Collections.Generic;

namespace LibraryFunctions.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}