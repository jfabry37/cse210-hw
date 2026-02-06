class WritingAssignment : Assignment
{
 private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title =title;
    }
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }

    // if the _studentName variable in the base class was private, we would not be able to access it in this method.
    //  We would have to create a getter method in the base class to access the _studentName variable.
    // public string GetWritingInformation()
    // {
    //      string studentName = GetStudentName(); // This would call the getter method in the base class to access the _studentName variable.
    //     return $"{_title} by {GetStudentName()}";
    // }
}