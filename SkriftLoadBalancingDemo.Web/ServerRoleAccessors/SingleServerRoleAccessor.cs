using Umbraco.Cms.Core.Sync;

namespace SkriftLoadBalancingDemo.Web.ServerRoleAccessors
{
	public sealed class SingleServerRoleAccessor : IServerRoleAccessor
	{
		public ServerRole CurrentServerRole => ServerRole.Single;
	}
}