using Domain;
namespace Application;

public class GroupService
{
    List<Group> groups = []; // 0 1 2 3 4 ...

    public void AddGroup(Group gr)
    {
        groups.Add(gr);
    }

    public void DeleteGroup(int id)
    {
        groups.RemoveAt(id - 1);
    }

    public void UpdateGroup(int id , string n , string d)
    {
        for (int i = 0; i < groups.Count(); i++)
        {
            if(id == groups[i].Id)
            {
                groups[i].Name = n;
                groups[i].Description = d;
                break;
            }
            else
            {
                System.Console.WriteLine("This Id not found");
            }
        }
    }

    public void GetInfo()
    {
        for (int i = 0; i < groups.Count(); i++)
        {
            Console.Write($"{groups[i].Id}. ");
            Console.WriteLine($"Name: {groups[i].Name}");
            Console.WriteLine($"Desc: {groups[i].Description}");
            Console.WriteLine();
        }
    }

    public void GetGroups()
    {
        foreach (Group item in groups)
        {
            Console.Write($"{item.Id}. ");
            Console.WriteLine($"Name: {item.Name}");
            Console.WriteLine($"Desc: {item.Description}");
            Console.WriteLine();
        }
    }



}
