using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Entity Framework (EF) is an object-relational mapper that enables .NET developers to work with relational data 
using domain-specific objects. It eliminates the need for most of the data-access code that developers usually 
need to write. In other words, EF provides a way to interact with databases using an object-oriented paradigm,
which is more intuitive and easier to use than traditional SQL queries. It is widely used in ASP.NET applications
to perform CRUD (Create, Read, Update, Delete) operations on databases.*/

namespace API.Entities;

    public class AppUser
    {
        public int Id {get; set;}
        public string UserName {get; set;}
    }
