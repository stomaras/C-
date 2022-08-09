// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using PublisherData;
using PublisherDomain;

// check if database exists
//using (PubContext context = new PubContext())
//{
//    context.Database.EnsureCreated();
//}

PubContext _context = new PubContext();
// work with populated data

void QueryAggregate()
{
    var author = _context.Authors.FirstOrDefault(a => a.LastName == "Lerman");
}

// SELECT TOP(1)

void AddSomeMoreAuthors()
{
    _context.Authors.Add(new Author { FirstName = "Rhoda", LastName = "Lerman" });
    _context.Authors.Add(new Author { FirstName = "Julie", LastName = "Lerman" });
    _context.Authors.Add(new Author { FirstName = "Don", LastName = "Jones" });
    _context.Authors.Add(new Author { FirstName = "Jim", LastName = "Christopher" });
    _context.Authors.Add(new Author { FirstName = "Stephen", LastName = "Haunts" });
    _context.SaveChanges();
}

void SkipAndTakeAuthors()
{
    var groupSize = 2;
    for (int i = 0; i < 5; i++)
    {
        var authors = _context.Authors.Skip(groupSize * i).Take(groupSize).ToList();
        Console.WriteLine($"Group {i}:");
        foreach (var author in authors)
        {
            Console.WriteLine($"{author.FirstName} {author.LastName}");
        }
    }

}

void QueryFilters()
{
    var name = "Josie";
    var authors = _context.Authors.Where(s => s.FirstName == name).ToList();
    //var authors = _context.Authors.Where(s => s.FirstName == "Josie").ToList();
}

// Search value is directly in query
// .Where(a=>a.FirstName == "Josie")
// Search Value in a variable
// var name = "Josie"
// .Where(a=>a.FirstName == name)


AddSomeMoreAuthors();
GetAuthors();
//AddAuthor();
//GetAuthors();
//AddAuthorWithBook();
//GetAuthorsWithBooks();

void AddAuthor()
{
    var author = new Author { FirstName = "Spyros", LastName = "Tom" };
    using var context = new PubContext();
    context.Authors.Add(author);    
    context.SaveChanges();
}

void GetAuthors()
{
    using var context = new PubContext();
    var query = context.Authors;
    var authors = query.ToList();
    foreach (var author in authors)
    {
        Console.WriteLine(author.FirstName + " " + author.LastName);
    }
}

void AddAuthorWithBook()
{
    var author = new Author { FirstName = "Julie", LastName = "Lerman" };
    author.Books.Add(new Book { Title = "Programming Entity Framework", PublishDate = new DateTime(2009, 1, 1) });
    author.Books.Add(new Book { Title = "Programming Entity Framework 2nd Ed", PublishDate = new DateTime(2010, 8, 1) });
    using var context = new PubContext();
    context.Authors.Add(author);
    context.SaveChanges();
}

void GetAuthorsWithBooks()
{
    using var context = new PubContext();
    var authors = context.Authors.Include(a => a.Books).ToList();
    foreach (var author in authors)
    {
        Console.WriteLine(author.FirstName + " " + author.LastName);
        foreach (var book in author.Books)
        {
            Console.WriteLine("*"+book.Title);
        }
    }
}

void InsertAuthor()
{
    var author = new Author { FirstName = "Frank", LastName = "Herbert" };
    _context.Authors.Add(author);
    _context.SaveChanges();
}

InsertAuthor();

void RetrieveAndUpdateAuthor()
{
    var author = _context.Authors.FirstOrDefault(a => a.FirstName == "Julie" && a.LastName == "Lerman");
    if (author != null)
    {
        author.FirstName = "Julia";
        _context.SaveChanges();
    }
}


/*
 * NOTES !!!
 * 
 * var author = context.Authors.AsNoTracking().FirstOrDefault()
 * 
 * AsNoTracking() returns a query, not a DbSet
 */

void RetrieveAndUpdateMultipleAuthors()
{
    var LermanAuthors = _context.Authors.Where(a => a.LastName == "Lehrman").ToList();
    foreach (var la in LermanAuthors)
    {
        la.LastName = "Lerman";
    }

    Console.WriteLine("Before"+ _context.ChangeTracker.DebugView.ShortView);
    _context.ChangeTracker.DetectChanges();
    Console.WriteLine("After:" + _context.ChangeTracker.DebugView.ShortView);

    _context.SaveChanges();
    // when you call save changes the context will take one last look at the obects
    // it's tracking

    // DbContext.ChangeTracker.DetectChanges()
    // Reads each object being tracked and updates state details in EntityEntry Object
    // DbContext.SaveChanges()
    // Always call DetectChanges for you 
    // DebugView has a deeper level of details 


}


void CoordinatedRetrieveAndUpdateAuthor()
{
    var author = FindThatAuthor(3);
    if (author?.FirstName == "Julie")
    {
        author.FirstName = "Julia";
        SaveThatAuthor(author);
    }
}

Author FindThatAuthor(int authorId)
{
    using var shortLivedContext = new PubContext();
    return shortLivedContext.Authors.Find(authorId);
}

void SaveThatAuthor(Author author)
{
    using var anotherShortLivedContext = new PubContext();
    // update method does two things , first it causes the context to begin tracking the author
    // and at the same time it instructs the context to set the state for that object to Modified
    // with update we update the entity in the dbset 
    anotherShortLivedContext.Authors.Update(author);
    anotherShortLivedContext.SaveChanges();
}


InsertMultipleAuthors();
void InsertMultipleAuthors()
{
    _context.Authors.AddRange(new Author { FirstName = "Ruth", LastName = "Ozeki" },
                              new Author { FirstName = "Sofia", LastName = "Segovia" },
                              new Author { FirstName = "Ursula K.", LastName = "LeGuin" }
                            );

    var authorList = new Author[]
    {
        new Author {FirstName = "Tom", LastName = "Spyros"},
        new Author {FirstName = "Tom", LastName = "Agatha"},
        new Author {FirstName = "Zarmakoupes", LastName = "George"}
    };
    _context.Authors.AddRange(authorList);
    _context.SaveChanges();
}

void InsertMultipleAuthorsPassedIn(List<Author> listOfAuthors)
{
    _context.Authors.AddRange(listOfAuthors);
    _context.SaveChanges();
}

