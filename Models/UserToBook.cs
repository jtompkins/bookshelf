namespace bookshelf.Models {
  public class UserToBook {
    public int Id { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public int BookId { get; set; }
    public Book Book { get; set; }

    public int YearRead { get; set; }
    public ReadStatus Status { get; set; }
    public Impression Impression { get; set; }
  }
}
