using System.Collections.Generic;

public class Exercise
{
    public string Name { get; set; }
    public List<Set> Sets { get; set; }

    public Exercise(string name)
    {
        Name = name;
        Sets = new List<Set>();
    }

    public void AddSet(Set set)
    {
        Sets.Add(set);
    }
}
