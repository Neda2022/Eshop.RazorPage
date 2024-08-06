namespace Eshop.RazorPage.Services.Comment;

public class CommentService: ICommentService
{
    private HttpClient _client;

    public CommentService(HttpClient client)
    {
        _client = client;
    }
}