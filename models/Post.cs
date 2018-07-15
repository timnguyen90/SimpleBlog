public class Post{
	public string Id { get; set; }
	public string Title { get; set; }
	public string Body { get; set; }

	public Post(){}
	public Post(string Id, string Title, string Body){
		this.Id = Id;
		this.Title = Title;
		this.Body = Body;
	}
	
}