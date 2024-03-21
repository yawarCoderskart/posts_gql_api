

using Posts_graphql.Domain.Models;
using Posts_graphql.Infrastructure.Repository;
namespace Posts_graphql.Application.Services
{
    public class PostService : IPostService
    {
        private readonly PostRepository _PostRepository;

        public PostService(PostRepository PostRepository)
        {
            _PostRepository = PostRepository;
        }
      
        public async Task<List<Post>> GetPostById(int? postId)
        {
            try
            {
                return await _PostRepository.GetPostById(postId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while logging in: {ex.Message}");
                return null;
            }
        }
        public async Task<Post> AddEditPost(Post newPost)
        {
            try
            {
                return await _PostRepository.AddEditPost(newPost);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while logging in: {ex.Message}");
                return null;
            }
        }


      
    }
}
