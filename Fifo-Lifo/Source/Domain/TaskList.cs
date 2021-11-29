using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Lifo.Source.Domain;

public class TaskList
{
    public Owner Owner { get; set; }
    public List<Task> Tasks { get; set; }

    public TaskList (Owner owner)
    {
        Owner = owner;
        Tasks = new List<Task> ();
    }
}
