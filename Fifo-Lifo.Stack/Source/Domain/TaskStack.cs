using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Lifo.Source.Domain;

public class TaskStack
{
    public Stack<Task> Tasks { get; set; }

    public TaskStack ()
    {
        Tasks = new Stack<Task> ();
    }
}
