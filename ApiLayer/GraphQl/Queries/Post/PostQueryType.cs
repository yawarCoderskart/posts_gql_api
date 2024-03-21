using HotChocolate.Types;
using posts_graphql.api.Types;

namespace posts_graphql.api.Query
{
    public class GetAllPostsQueryType : ObjectType<PostQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<PostQuery> descriptor)
        {
            descriptor.Field(q => q.GetPostById(default!))
                .Type<ListType<PostType>>() 
                .Name("GetPostById")
                .Description("pass post id to get post by id , do not post Id and you will get all posts as list in both cases");
        }
    }
 

}
