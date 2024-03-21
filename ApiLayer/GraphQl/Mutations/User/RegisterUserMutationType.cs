using Posts_graphql.Domain.Models;
using posts_graphql.api.Types;
using Posts_graphql.Application.Services;

public class RegisterUserMutationType : ObjectType
{
    protected override void Configure(IObjectTypeDescriptor descriptor)
    {
        descriptor.Field<UserResolver>(t => t.RegisterUserAsync(default!, default!))
            .Argument("newUser", a => a.Type<NonNullType<RegisterUserInputType>>())
            .Type<UserType>()
            .Name("registerUser")
            .Description("Register a new user.");
    }

    private class UserResolver
    {
        public async Task<UserProfile> RegisterUserAsync(UserProfile newUser, [Service] UserService userService)
        {
            return await userService.RegisterUserAsync(newUser);
        }
    }
}
