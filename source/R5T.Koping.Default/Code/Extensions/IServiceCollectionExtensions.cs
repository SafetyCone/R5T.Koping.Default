using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Koping.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFolderProjectTypeGuidProvider"/> implementation of <see cref="IVisualStudioSolutionFolderProjectTypeGuidProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultVisualStudioSolutionFolderProjectTypeGuidProvider(this IServiceCollection services)
        {
            services.AddSingleton<IVisualStudioSolutionFolderProjectTypeGuidProvider, VisualStudioSolutionFolderProjectTypeGuidProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFolderProjectTypeGuidProvider"/> implementation of <see cref="IVisualStudioSolutionFolderProjectTypeGuidProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IVisualStudioSolutionFolderProjectTypeGuidProvider> AddDefaultVisualStudioSolutionFolderProjectTypeGuidProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IVisualStudioSolutionFolderProjectTypeGuidProvider>(() => services.AddDefaultVisualStudioSolutionFolderProjectTypeGuidProvider());
            return serviceAction;
        }
    }
}
