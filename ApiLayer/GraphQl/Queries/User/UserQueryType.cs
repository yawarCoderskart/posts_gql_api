using HotChocolate.Types;
using posts_graphql.api.Types;

namespace posts_graphql.api.Query
{
    public class GetAllUsersQueryType : ObjectType<UserQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<UserQuery> descriptor)
        {
            descriptor.Field(q => q.GetAllUsers())
                .Type<ListType<UserType>>() 
                .Name("GetAllUsers")
                .Description("Get all users");
        }
    }
    public class LoginQueryType : ObjectType<UserQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<UserQuery> descriptor)
        {
            descriptor.Field(q => q.LoginUser(default!, default!)) 
            .Type<UserType>() 
            .Name("LoginUser")
            .Description("Authenticate user and return user information");
        }
    }
    public class IsUserExistsAsync : ObjectType<UserQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<UserQuery> descriptor)
        {
            descriptor.Field(q => q.IsUserExistsAsync(default!)) 
            .Type<BooleanType>() 
            .Name("IsUserExistsAsync")
            .Description("Check wither user with same email exist or not");
        }
    }

}
