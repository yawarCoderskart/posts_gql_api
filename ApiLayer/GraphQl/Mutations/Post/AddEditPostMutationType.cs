using Posts_graphql.Domain.Models;
using posts_graphql.api.Types;
using Posts_graphql.Application.Services;

public class AddEditPostMutationType : ObjectType
{
    protected override void Configure(IObjectTypeDescriptor descriptor)
    {
        descriptor.Field<PostResolver>(t => t.AddEditPostAsync(default!, default!))
            .Argument("newPost", a => a.Type<NonNullType<AddEditPostInputType>>())
            .Type<PostType>()
            .Name("AddEditPost")
            .Description(" if you do not provide post id then new post will be created , if post id is provided then existing post with same id will be updated , if provide positId and FlgDelte = true then existing post with that id will be delted ");
    }

    private class PostResolver
    {
        public async Task<Post> AddEditPostAsync(Post newPost, [Service] PostService postService)
        {
            return await postService.AddEditPost(newPost);
        }
    }
}
