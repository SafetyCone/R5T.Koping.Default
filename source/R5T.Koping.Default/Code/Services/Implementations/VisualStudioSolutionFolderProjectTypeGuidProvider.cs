using System;

using R5T.Koping.Base;using R5T.T0064;


namespace R5T.Koping.Default
{[ServiceImplementationMarker]
    public class VisualStudioSolutionFolderProjectTypeGuidProvider : IVisualStudioSolutionFolderProjectTypeGuidProvider,IServiceImplementation
    {
        public Guid GetVisualStudioSolutionFolderProjectTypeGuid()
        {
            return Constants.SolutionFolderProjectTypeGuid;
        }
    }
}
