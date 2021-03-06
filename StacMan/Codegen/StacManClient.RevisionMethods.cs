// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StackExchange.StacMan
{
    public partial class StacManClient : IRevisionMethods
    {
        /// <summary>
        /// Stack Exchange API Revisions methods
        /// </summary>
        public IRevisionMethods Revisions
        {
            get { return this; }
        }

        Task<StacManResponse<Revision>> IRevisionMethods.GetByIds(string site, IEnumerable<Guid> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidateEnumerable(ids, "ids");
            ValidatePaging(page, pagesize);

            var ub = new ApiUrlBuilder(String.Format("/revisions/{0}", String.Join(";", ids)), useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);

            return CreateApiTask<Revision>(ub, filterObj, "/revisions/{ids}");
        }
    }

    public interface IRevisionMethods
    {
        /// <summary>
        /// Get all revisions identified by a set of ids. (API Method: "/revisions/{ids}")
        /// </summary>
        Task<StacManResponse<Revision>> GetByIds(string site, IEnumerable<Guid> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null);

    }
}

#pragma warning restore 1591
