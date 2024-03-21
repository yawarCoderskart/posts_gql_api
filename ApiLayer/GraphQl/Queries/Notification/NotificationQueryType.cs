using HotChocolate.Types;
using posts_graphql.api.Types;

namespace posts_graphql.api.Query
{
    public class GetAllNotificationsQueryType : ObjectType<NotificationQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<NotificationQuery> descriptor)
        {
            descriptor.Field(q => q.GetNotificationById(default!))
                .Type<ListType<NotificationType>>() 
                .Name("GetNotificationById")
                .Description("pass Notification id to get Notification by id , do not Notification Id and you will get all Notifications as list in both cases");
        }
    }
 

}
