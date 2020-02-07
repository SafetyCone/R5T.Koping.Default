using System;

using R5T.Koping.Base;


namespace R5T.Koping.Default
{
    public class VisualStudioSolutionFolderProjectTypeGuidProvider : IVisualStudioSolutionFolderProjectTypeGuidProvider
    {
        public Guid GetVisualStudioSolutionFolderProjectTypeGuid()
        {
            return Constants.SolutionFolderProjectTypeGuid;
        }
    }
}
