﻿namespace MarketingPageAcceptanceTests.Actions.Utils
{
    internal static class Queries
    {
        internal const string GetMarketingDetail = "SELECT Features, AboutUrl from [dbo].[MarketingDetail] where SolutionId=@solutionId";
        internal const string GetSolution = "SELECT Summary, FullDescription, SupplierStatusId from [dbo].[Solution] where Id=@solutionId";
        internal const string CreateNewSolution = "INSERT INTO Solution (Id, OrganisationId, Name, Version, PublishedStatusId, AuthorityStatusId, SupplierStatusId, OnCatalogueVersion) values (@solutionId, '1000000', @solutionName, @solutionVersion, 1,1,1, 0)";
        internal const string CreateMarketingDetail = "INSERT INTO MarketingDetail (SolutionId) values (@solutionId)";
        internal const string DeleteSolution = "DELETE from Solution where Id=@solutionId";
        internal const string DeleteMarketingDetail = "DELETE from MarketingDetail where SolutionId=@solutionId";
    }
}