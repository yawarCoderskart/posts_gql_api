
using Posts_graphql.Application.Services;
using Posts_graphql.Domain.Models;

namespace posts_graphql.api.Query;
public class UserQuery
{
    private readonly UserService _UserService;

    public UserQuery(UserService UserService)
    {
        _UserService = UserService;
    }

    public async Task<UserProfile> LoginUser(string email , string password)
    {
        return await _UserService.LoginUserAsync(email, password);
    }
    public async Task<List<UserProfile>> GetAllUsers()
    {
        return  await _UserService.GetAllUsers();
    }
    public async Task<bool?> IsUserExistsAsync(string email)
    {
        return  await _UserService.IsUserExistsAsync(email);
    }

}