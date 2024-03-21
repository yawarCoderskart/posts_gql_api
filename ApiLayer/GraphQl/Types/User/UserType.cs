namespace posts_graphql.api.Types;

using HotChocolate.Types;
using Posts_graphql.Domain.Models;

public class UserType : ObjectType<UserProfile>
    {
        protected override void Configure(IObjectTypeDescriptor<UserProfile> descriptor)
        {
            descriptor.Field(u => u.Id)
                .Type<NonNullType<IntType>>()
                .Name("id")
                .Description("The unique identifier of the user.");
            
            descriptor.Field(u => u.Email)
                .Type<NonNullType<StringType>>()
                .Name("email")
                .Description("The email address of the user.");

            descriptor.Field(u => u.Password)
                .Type<NonNullType<StringType>>()
                .Name("password")
                .Description("The password of the user.");
            descriptor.Field(u => u.FirstName)
                .Type<NonNullType<StringType>>()
                .Name("FirstName")
                .Description("The FirstName of the user.");
            descriptor.Field(u => u.LastName)
                .Type<NonNullType<StringType>>()
                .Name("LastName")
                .Description("The LastName of the user.");
            descriptor.Field(u => u.PhNo)
                .Type<NonNullType<StringType>>()
                .Name("PhNo")
                .Description("The Phone Number of the user.");
            descriptor.Field(u => u.AddedBy)
                .Type<NonNullType<StringType>>()
                .Name("AddedBy")
                .Description("user id who added this user.");
            descriptor.Field(u => u.AddedDateTime)
                .Type<NonNullType<StringType>>()
                .Name("AddedDateTime")
                .Description("The AddedDateTime of the user.");
            descriptor.Field(u => u.UpdatedBy)
                .Type<NonNullType<StringType>>()
                .Name("UpdatedBy")
                .Description("The user id who updatedthis user.");
            descriptor.Field(u => u.UpdatedDateTime)
                .Type<NonNullType<StringType>>()
                .Name("UpdatedDateTime")
                .Description("The UpdatedDateTime of the user.");
            descriptor.Field(u => u.FlgDelete)
                .Type<NonNullType<StringType>>()
                .Name("FlgDelete")
                .Description("FlgDelete is a boolean to represent state of user deleted or not.");
          

            // we can add all other fields as well    

        }
    }

