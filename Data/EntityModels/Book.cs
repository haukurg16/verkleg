namespace BookCave.Data.EntityModels
{
  public class Book
  {
    public int Id {get; set; }
    public string Title {get; set; }
    public string Genre {get; set; }
    public int ReleseYear {get; set; }
    public int AuthorId {get; set; }

  }
}