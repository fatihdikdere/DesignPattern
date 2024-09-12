using Iterator;

var library = new Library();

library.AddBook(new Book("title1", "author1"));
library.AddBook(new Book("title2", "author2"));
library.AddBook(new Book("title3", "author3"));

var iterator = library.CreateIterator();

while (iterator.HasNext())
{
    var book = iterator.Next();

    Console.WriteLine($"Book => Title: {book?.Title} && Author: {book?.Author}");
}

Console.ReadKey();