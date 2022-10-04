namespace Claims;

public interface IClientDetail
{
    Entrance Entrance { get; set; }
    Software Software { get; init; }
    ///add something to say if  is a website 
    public bool IsWebSite { get; }
}