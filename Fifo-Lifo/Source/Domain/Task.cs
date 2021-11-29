using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Lifo.Source.Domain;

public class Task
{
    private string _taskName;
    public string TaskName { get { return _taskName; } set { _taskName = value; } }

    public Task (string task)
    {
        _taskName = task;
    }
}

