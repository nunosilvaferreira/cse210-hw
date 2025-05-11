using System.Collections.Generic;

// A code template for the category of things known as Resume. The
// responsibility of a Resume is to hold and display personal employment information.
public class Resume
{
    // The C# convention is to start member variables with an underscore _
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    // A method that displays the resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        
        // Iterate through each Job instance in _jobs and display them
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}