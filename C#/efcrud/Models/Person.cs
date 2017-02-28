namespace efcrud.Models
{
    public class Person : BaseEntity
    {
        public int PersonID {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public int Age {get; set;}
    }
}