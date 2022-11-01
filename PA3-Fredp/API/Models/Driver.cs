using PA3_Fredp.API.Interfaces;

namespace PA3_Fredp;

public class Driver
{
    public Guid id { get; set; }

    public string name { get; set; }

    public int rating {get; set;}

    public string dateHired  { get; set; }

    public Boolean deleted {get; set;}
}
