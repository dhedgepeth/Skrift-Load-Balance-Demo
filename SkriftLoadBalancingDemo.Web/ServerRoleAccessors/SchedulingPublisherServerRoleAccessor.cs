using Umbraco.Cms.Core.Sync;

namespace SkriftLoadBalancingDemo.Web.ServerRoleAccessors
{
	public sealed class SchedulingPublisherServerRoleAccessor : IServerRoleAccessor
	{
		public ServerRole CurrentServerRole => ServerRole.SchedulingPublisher;
	}
}