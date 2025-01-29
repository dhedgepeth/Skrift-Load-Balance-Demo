using Umbraco.Cms.Core.Sync;

namespace SkriftLoadBalancingDemo.Web.ServerRoleAccessors
{
	public sealed class SubscriberServerRoleAccessor : IServerRoleAccessor
	{
		public ServerRole CurrentServerRole => ServerRole.Subscriber;
	}
}
