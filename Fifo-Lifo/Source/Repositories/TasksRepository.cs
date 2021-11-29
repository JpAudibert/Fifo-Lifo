using Fifo_Lifo.Source.Domain;
using Fifo_Lifo.Source.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Lifo.Source.Repositories;

public class TasksRepository : ITasksRepository
{
    public List<TaskList> Lists { get; set; }

    public TasksRepository(List<TaskList>? lists = null)
    {
        if (lists != null)
        {
            Lists = lists;
            return;
        }

        Lists = new List<TaskList>();
    }

    public TaskList InsertTask(Owner owner, string task)
    {
        try
        {
            TaskList TaskList = (TaskList)Lists.Where(list => list.Owner.Id == owner.Id);

            TaskList.Tasks.Add(new Domain.Task(task));

            return TaskList;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public TaskList RemoveTask(Owner owner)
    {
        try
        {
            TaskList TaskList = (TaskList)Lists.Where(list => list.Owner.Id == owner.Id);

            TaskList.Tasks.RemoveAt(TaskList.Tasks.Count - 1);

            return TaskList;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public string ReturnNextTask(Owner owner)
    {
        try
        {
            TaskList TaskList = (TaskList)Lists.Where(list => list.Owner.Id == owner.Id);

            if (TaskList == null)
            {
                return "You don't have tasks";
            }

            return $"{owner.Name} - {TaskList.Tasks[TaskList.Tasks.Count - 1].TaskName}";
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}

