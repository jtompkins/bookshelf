namespace bookshelf.Models {
  public enum ReadStatus {
    Wishlist,
    CurrentlyReading,
    Read,
    DidntFinish
  }

  public enum Impression {
    NoOpinion = 0,
    Liked,
    Disliked
  }

  public enum BookType {
    Book,
    ComicBook,
    AudioBook
  }
}
