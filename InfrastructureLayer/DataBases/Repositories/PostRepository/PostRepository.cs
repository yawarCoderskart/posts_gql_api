using Microsoft.EntityFrameworkCore;
using Posts_graphql.Domain.Models;
using Posts_graphql.Infrastructure.Context;

namespace Posts_graphql.Infrastructure.Repository;
public class PostRepository : IPostRepository
{
    protected readonly IDbContextFactory<PostGrapghQlDbContext> _contextFactory;
    protected readonly PostGrapghQlDbContext dbContext;

    public PostRepository(IDbContextFactory<PostGrapghQlDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
        dbContext = contextFactory.CreateDbContext();
    }

    public async Task<List<Post>> GetPostById(int? postId)
    {
        try
        {
            if (postId == null)
            {
                return await dbContext.Post.Where(p => p.FlgDelete == false).ToListAsync();
            }
            else
            {
                return await dbContext.Post.Where(p => p.FlgDelete == false && p.Id == postId).ToListAsync();
            }

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
            dbContext.Post.Add(newPost);
            await dbContext.SaveChangesAsync();
            return newPost;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while logging in: {ex.Message}");
            return null;
        }
    }


}
