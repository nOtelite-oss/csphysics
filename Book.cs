using System;

namespace csphysics
{
  class Book
  {
    private string title;
    private string author;
    private int pages;
    private string rating;

    public Book(string aTitle, string aAuthor, int aPages, string aRating)
    {
      title = aTitle;
      author = aAuthor;
      pages = aPages;
      Rating = aRating;
    }

    public void Print()
    {
      Console.WriteLine("Title: " + title);
      Console.WriteLine("Author: " + author);
      Console.WriteLine("Pages: " + Convert.ToString(pages));
      Console.WriteLine("Rating: " + rating);
    }

    public string Rating
    {
      get { return rating; }
      set
      {
        if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
        {
          rating = value;
        }
        else
        {
          rating = "NR";
        }
      }
    }
  }
}
