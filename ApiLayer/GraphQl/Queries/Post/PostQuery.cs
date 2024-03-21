
using Posts_graphql.Application.Services;
using Posts_graphql.Domain.Models;

namespace posts_graphql.api.Query;
public class PostQuery
{
    private readonly PostService _PostService;

    public PostQuery(PostService PostService)
    {
        _PostService = PostService;
    }

    public async Task<List<Post>> GetPostById(int? postId)
    {
        return await _PostService.GetPostById(postId);
    }
  

}