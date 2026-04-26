public class Student
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string email { get; set; } 
    public string course { get; set; }
}

// Data annotation are attributes used in model class to define validations rules
//      [required], stringlength(50), emailaddress, range=>age
