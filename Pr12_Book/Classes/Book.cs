﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr12_Book.Classes
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Author> Authors { get; set; }
        public int Year {  get; set; }
        public Book(int Id, string Name, List<Genre> Genres, List<Author> Authors, int Year)
        {
            this.Id = Id;
            this.Name = Name;
            this.Genres = Genres;
            this.Authors = Authors;
            this.Year = Year;
        }
        public static List<Book> AllBook()
        {
            List<Book> allBook = new List<Book>();
            allBook.Add(new Book(1, "Путешествие в Элевсин", Genre.AllGenres().FindAll(x => x.Id == 1), Author.AllAuthor().FindAll(x => x.Id == 1),2023));
            allBook.Add(new Book(2, "Чапапев и Пустота", Genre.AllGenres().FindAll(x => x.Id == 1), Author.AllAuthor().FindAll(x => x.Id == 1), 2008));
            allBook.Add(new Book(3, "Дебютная постановка. Том 1", Genre.AllGenres().FindAll(x => x.Id == 2), Author.AllAuthor().FindAll(x => x.Id == 2), 2023));
            allBook.Add(new Book(4, "Дебютная постановка. Том 2", Genre.AllGenres().FindAll(x => x.Id == 2), Author.AllAuthor().FindAll(x => x.Id == 2), 2023));
            allBook.Add(new Book(5, "Охота на попаданку. Бракованная жена", Genre.AllGenres().FindAll(x => x.Id == 2|| x.Id == 3 || x.Id == 4), Author.AllAuthor().FindAll(x => x.Id == 3), 2022));
            return allBook;
        }
        public string ToGenres()
        {
            string toGenres = "";
            for (int iGenre = 0; iGenre < this.Genres.Count; iGenre++)
            {
                toGenres += this.Genres[iGenre].Name;
                if (iGenre < this.Genres.Count - 1)
                    toGenres += ", ";
            }
            return toGenres;
        }
        public string ToAuthors()
        {
            string toAuthors = "";
            for (int iAuthors = 0; iAuthors < this.Authors.Count; iAuthors++)
            {
                toAuthors += this.Authors[iAuthors].FIO;
                if(iAuthors < this.Authors.Count - 1)
                    toAuthors += ", ";
            }
            return toAuthors;
        }
    }
}
