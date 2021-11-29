using Fifo_Lifo.Source.Domain;
using Fifo_Lifo.Source.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Lifo.Source.Repositories;

internal class TaskListRepository : ITaskListRepository
{
    public TaskListRepository(List<TaskList> lists)
    {
        Lists = lists;
    }

    public List<TaskList> Lists { get; set; }

    public void createTaskList(Owner owner)
    {
        try
        {
            TaskList newTaskList = new TaskList(owner);

            Lists.Add(newTaskList);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

    }
}
