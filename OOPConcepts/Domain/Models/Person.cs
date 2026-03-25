abstract class Person
{
    public required string Name { get; set; }

    /// <summary>
    ///  displays person's details - must be overriden in derived class.
    ///  Return type: void
    /// </summary>
    public abstract void GetDetails();
}
