namespace Paramore.Domain.Speakers
{
    public class Name
    {
        public string Name { get; private set;}

        public Name(string name)
        {
            this.Name = name;
        }
    }
}