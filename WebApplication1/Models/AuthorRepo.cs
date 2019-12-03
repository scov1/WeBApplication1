using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{

    public class Author
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
    }
    public class AuthorRepo
    {
        public static IList<Author> authors = new List<Author> {
            new Author {Id = 1, AuthorName = "Pushkin"},
            new Author {Id = 2, AuthorName = "King"}
        };


        public static IList<Author> List()
        {
            return authors;
        }

        public static void Create(Author author)
        {
            author.Id = authors.Max(x => x.Id) + 1;
            authors.Add(author);
        }

        public static void Delete(int id)
        {
            var exists = authors.FirstOrDefault(x => x.Id == id);
            if (exists == null)
                throw new Exception("Mo match found");
            else
                authors.Remove(exists);
        }
    }

}