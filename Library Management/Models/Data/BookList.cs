using System;
using System.Collections.Generic;

namespace Library_Management.Models.Data;

public partial class BookList
{
    public Guid BookId { get; set; }

    public string? Title { get; set; }

    public string? Isbn { get; set; }

    public string? Description { get; set; }

    public string? Genre { get; set; }

    public DateTime? PublishedDate { get; set; }

    public string? CoverImageUrl { get; set; }

    public string? AuthorName { get; set; }

    public string? AuthorProfileImageUrl { get; set; }

    public int TotalCopies { get; set; }

    public int AvailableCopies { get; set; }
}
