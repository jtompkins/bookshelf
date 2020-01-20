using System.Collections.Generic;

namespace bookshelf.Models {
  public class User {
    public int Id { get; set; }

    public string DisplayName { get; set; }

    public IEnumerable<UserToBook> Books { get; set; }
  }
}
