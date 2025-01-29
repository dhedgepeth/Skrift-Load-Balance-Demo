using Umbraco.Cms.Core;

namespace SkriftLoadBalancingDemo.Web
{
	public static partial class IUmbracoBuilderExtensions
	{
		public static IUmbracoBuilder AddSqlServerCache(this IUmbracoBuilder builder)
		{
			builder.Services.AddDistributedSqlServerCache(options =>
			{
				options.SchemaName = "dbo";
				options.TableName = "SessionCache";
				options.ConnectionString = builder.Config.GetConnectionString(Constants.System.UmbracoConnectionName);
			});

			return builder;
		}
	}
}