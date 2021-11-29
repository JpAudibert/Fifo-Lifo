using Fifo_Lifo.Source.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Lifo.Source.Interfaces;

public interface ITaskListRepository
{
    public void createTaskList(Owner owner);
}
