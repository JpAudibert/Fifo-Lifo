using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Lifo.Source.Domain;

public class Owner
{
    private int _id;
    private string _name;

    public int Id { set; get; }
    public string Name { set; get; }

    public Owner(int id, string name)
    {
        _id = id;
        _name = name;
        Id = id;
        Name = name;
    }
}

