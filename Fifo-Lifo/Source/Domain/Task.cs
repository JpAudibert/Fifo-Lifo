using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Lifo.Source.Domain;

public class Task
{
    private string _taskName;
    private string _owner;

    public string TaskName { get { return _taskName; } set { _taskName = value; } }
    public string Owner { get { return _owner; } set { _owner = value; } }

    public Task(string owner, string task)
    {
        _taskName = task;
        _owner = owner;
    }
}

