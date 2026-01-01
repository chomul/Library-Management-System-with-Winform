using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookManager
{
    class DataManager
    {
        public static List<Book> Books { get; set; } = new List<Book>();
        public static List<User> Users { get; set; } = new List<User>();

        static DataManager()
        {
            Load();
        }
        
        public static void Load()
        {
            try
            {
                string booksOutput = File.ReadAllText(@"./Books.xml");
                XElement booksXElement = XElement.Parse(booksOutput);
                Books = (from item in booksXElement.Descendants("book")
                    select new Book()
                    {
                        Isbn = item.Element("isbn").Value,
                        Name = item.Element("name").Value,
                        Publisher = item.Element("publisher").Value,
                        Page = int.Parse(item.Element("page").Value),
                        BorrowedAt = DateTime.Parse(item.Element("borrowedAt").Value),
                        isBorrowed = bool.Parse(item.Element("isBorrowed").Value),
                        UserId = int.Parse(item.Element("userId").Value),
                        UserName = item.Element("userName").Value
                    }).ToList<Book>();
                
                string usersOutput = File.ReadAllText(@"./Users.xml");
                XElement usersXElement = XElement.Parse(usersOutput);
                Users = (from item in usersXElement.Descendants("user")
                    select new User()
                    {
                        Id = int.Parse(item.Element("id").Value),
                        Name = item.Element("name").Value
                    }).ToList<User>();
            }
            catch (Exception ex)
            {
                Save();
            }
        }

        public static void Save()
        {
            string booksOutput = "";
            booksOutput += "<books>\n";
            foreach (var book in Books)
            {
                booksOutput += $"<book>\n";
                booksOutput += $"   <isbn>{book.Isbn}</isbn>\n";
                booksOutput += $"   <name>{book.Name}</name>\n";
                booksOutput += $"   <publisher>{book.Publisher}</publisher>\n";
                booksOutput += $"   <page>{book.Page}</page>\n";
                booksOutput += $"   <borrowedAt>{book.BorrowedAt.ToString("yyyy-MM-dd HH:mm:ss")}</borrowedAt>\n";
                booksOutput += $"   <isBorrowed>{book.isBorrowed}</isBorrowed>\n";
                booksOutput += $"   <userId>{book.UserId}</userId>\n";
                booksOutput += $"   <userName>{book.UserName}</userName>\n";
                booksOutput += $"</book>\n";
            }
            booksOutput += "</books>";
            
            string usersOutput = "";
            usersOutput += "<users>\n";
            foreach (var user in Users)
            {
                usersOutput += $"<user>\n";
                usersOutput += $"   <id>{user.Id}</id>\n";
                usersOutput += $"   <name>{user.Name}</name>\n";
                usersOutput += $"</user>\n";
            }
            usersOutput += "</users>";
            
            File.WriteAllText(@"./Books.xml", booksOutput);
            File.WriteAllText(@"./Users.xml", usersOutput);
        }
    }
}