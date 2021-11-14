﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libanvl.Test;

internal enum Org
{
    Alpha,
    Beta,
    Gamma,
    Delta
}

internal record Person(string FirstName, string LastName, Org Org);

internal record DeltaPerson(string FirstName, string LastName) : Person(FirstName, LastName, Org.Delta);

internal record Book(string Title, Person Author, Person Editor);

internal record Library(Opt<IEnumerable<Book>> Books, Opt<Person> Curator);
