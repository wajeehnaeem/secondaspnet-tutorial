namespace newProject.Models
{
    public class Post
    {
        public string ID {get;set;}
        public string Title {get;set;}
        public string Content {get;set;}   
        public ApplicationUser CreatedBy {get;set;}
    }
}