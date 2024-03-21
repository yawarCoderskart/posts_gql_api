
using Posts_graphql.Application.Services;
using Posts_graphql.Domain.Models;

namespace posts_graphql.api.Query;
public class NotificationQuery
{
    private readonly NotificationService _NotificationService;

    public NotificationQuery(NotificationService NotificationService)
    {
        _NotificationService = NotificationService;
    }

    public async Task<List<Notification>> GetNotificationById(int? NotificationId)
    {
        return await _NotificationService.GetNotificationById(NotificationId);
    }
  

}