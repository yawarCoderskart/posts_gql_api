using Posts_graphql.Domain.Models;
using apiApp =  posts_graphql.api.Types;
using Posts_graphql.Application.Services;

public class AddEditNotificationMutationType : ObjectType
{
    protected override void Configure(IObjectTypeDescriptor descriptor)
    {
        descriptor.Field<NotificationResolver>(t => t.AddEditNotificationAsync(default!, default!))
            .Argument("newNotification", a => a.Type<NonNullType<AddEditNotificationInputType>>())
            .Type<apiApp.NotificationType>()
            .Name("AddEditNotification")
            .Description(" if you do not provide Notification id then new Notification will be created , if Notification id is provided then existing Notification with same id will be updated , if provide positId and FlgDelte = true then existing Notification with that id will be delted ");
    }

    private class NotificationResolver
    {
        public async Task<Notification> AddEditNotificationAsync(Notification newNotification, [Service] NotificationService NotificationService)
        {
            return await NotificationService.AddEditNotification(newNotification);
        }
    }
}
