using System.Collections.Generic;
using System.Linq;
using BookCave.Data;
using BookCave.Data.EntityModels;
using BookCave.Models.ViewModels;

namespace BookCave.Repositories
{
  public class AuthorRepo
  {
    private DataContext _db;

    public AuthorRepo()
    {
      _db = new DataContext();
    }
    public List<AuthorListViewModel> GetAllAuthors()
    {
      var authors = (from a in _db.Authors
                  select new AuthorListViewModel
                  {
                    Id = a.Id,
                    Name = a.Name
                  }).ToList();
      return authors;
    }
  }
}