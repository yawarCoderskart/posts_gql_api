using Posts_graphql.Domain.Models;

namespace Posts_graphql.Infrastructure.Repository;

public interface INotificationRepository
{
    Task<List<Notification>> GetNotificationById(int? id);
    Task<Notification> AddEditNotification(Notification newNotification);
   
}
