namespace bookshelf.Models {
  public class Book {
    public int Id { get; set; }

    public string Name { get; set; }
    public string Author { get; set; }

    public string CoverImage { get; set; }
    public string Url { get; set; }

    public BookType Type { get; set; }
  }
}
