using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Lifo.Source.Domain;

public class TaskList
{
    public List<Task> Tasks { get; set; }

    public TaskList ()
    {
        Tasks = new List<Task> ();
    }
}
