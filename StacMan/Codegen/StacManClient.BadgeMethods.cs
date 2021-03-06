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
    public partial class StacManClient : IBadgeMethods
    {
        /// <summary>
        /// Stack Exchange API Badges methods
        /// </summary>
        public IBadgeMethods Badges
        {
            get { return this; }
        }

        Task<StacManResponse<Badge>> IBadgeMethods.GetAll(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Badges.AllSort? sort = null, Badges.Rank? minrank = null, Badges.Rank? maxrank = null, string minname = null, string maxname = null, Badges.BadgeType? mintype = null, Badges.BadgeType? maxtype = null, Order? order = null, string inname = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, minrank: minrank, maxrank: maxrank, minname: minname, maxname: maxname, mintype: mintype, maxtype: maxtype);

            var ub = new ApiUrlBuilder("/badges", useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", minrank);
            ub.AddParameter("max", maxrank);
            ub.AddParameter("min", minname);
            ub.AddParameter("max", maxname);
            ub.AddParameter("min", mintype);
            ub.AddParameter("max", maxtype);
            ub.AddParameter("order", order);
            ub.AddParameter("inname", inname);

            return CreateApiTask<Badge>(ub, filterObj, "/badges");
        }

        Task<StacManResponse<Badge>> IBadgeMethods.GetByIds(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Badges.AllSort? sort = null, Badges.Rank? minrank = null, Badges.Rank? maxrank = null, string minname = null, string maxname = null, Badges.BadgeType? mintype = null, Badges.BadgeType? maxtype = null, Order? order = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidateEnumerable(ids, "ids");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, minrank: minrank, maxrank: maxrank, minname: minname, maxname: maxname, mintype: mintype, maxtype: maxtype);

            var ub = new ApiUrlBuilder(String.Format("/badges/{0}", String.Join(";", ids)), useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", minrank);
            ub.AddParameter("max", maxrank);
            ub.AddParameter("min", minname);
            ub.AddParameter("max", maxname);
            ub.AddParameter("min", mintype);
            ub.AddParameter("max", maxtype);
            ub.AddParameter("order", order);

            return CreateApiTask<Badge>(ub, filterObj, "/badges/{ids}");
        }

        Task<StacManResponse<Badge>> IBadgeMethods.GetNamed(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Badges.Sort? sort = null, Badges.Rank? minrank = null, Badges.Rank? maxrank = null, string minname = null, string maxname = null, Order? order = null, string inname = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, minrank: minrank, maxrank: maxrank, minname: minname, maxname: maxname);

            var ub = new ApiUrlBuilder("/badges/name", useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", minrank);
            ub.AddParameter("max", maxrank);
            ub.AddParameter("min", minname);
            ub.AddParameter("max", maxname);
            ub.AddParameter("order", order);
            ub.AddParameter("inname", inname);

            return CreateApiTask<Badge>(ub, filterObj, "/badges/name");
        }

        Task<StacManResponse<Badge>> IBadgeMethods.GetRecent(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidatePaging(page, pagesize);

            var ub = new ApiUrlBuilder("/badges/recipients", useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);

            return CreateApiTask<Badge>(ub, filterObj, "/badges/recipients");
        }

        Task<StacManResponse<Badge>> IBadgeMethods.GetRecentByIds(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidateEnumerable(ids, "ids");
            ValidatePaging(page, pagesize);

            var ub = new ApiUrlBuilder(String.Format("/badges/{0}/recipients", String.Join(";", ids)), useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);

            return CreateApiTask<Badge>(ub, filterObj, "/badges/{ids}/recipients");
        }

        Task<StacManResponse<Badge>> IBadgeMethods.GetTagBased(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Badges.Sort? sort = null, Badges.Rank? minrank = null, Badges.Rank? maxrank = null, string minname = null, string maxname = null, Order? order = null, string inname = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, minrank: minrank, maxrank: maxrank, minname: minname, maxname: maxname);

            var ub = new ApiUrlBuilder("/badges/tags", useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", minrank);
            ub.AddParameter("max", maxrank);
            ub.AddParameter("min", minname);
            ub.AddParameter("max", maxname);
            ub.AddParameter("order", order);
            ub.AddParameter("inname", inname);

            return CreateApiTask<Badge>(ub, filterObj, "/badges/tags");
        }
    }

    public interface IBadgeMethods
    {
        /// <summary>
        /// Get all badges on the site, in alphabetical order. (API Method: "/badges")
        /// </summary>
        Task<StacManResponse<Badge>> GetAll(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Badges.AllSort? sort = null, Badges.Rank? minrank = null, Badges.Rank? maxrank = null, string minname = null, string maxname = null, Badges.BadgeType? mintype = null, Badges.BadgeType? maxtype = null, Order? order = null, string inname = null);

        /// <summary>
        /// Get the badges identified by ids. (API Method: "/badges/{ids}")
        /// </summary>
        Task<StacManResponse<Badge>> GetByIds(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Badges.AllSort? sort = null, Badges.Rank? minrank = null, Badges.Rank? maxrank = null, string minname = null, string maxname = null, Badges.BadgeType? mintype = null, Badges.BadgeType? maxtype = null, Order? order = null);

        /// <summary>
        /// Get all non-tagged-based badges in alphabetical order. (API Method: "/badges/name")
        /// </summary>
        Task<StacManResponse<Badge>> GetNamed(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Badges.Sort? sort = null, Badges.Rank? minrank = null, Badges.Rank? maxrank = null, string minname = null, string maxname = null, Order? order = null, string inname = null);

        /// <summary>
        /// Get badges recently awarded on the site. (API Method: "/badges/recipients")
        /// </summary>
        Task<StacManResponse<Badge>> GetRecent(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null);

        /// <summary>
        /// Get the recent recipients of the given badges. (API Method: "/badges/{ids}/recipients")
        /// </summary>
        Task<StacManResponse<Badge>> GetRecentByIds(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null);

        /// <summary>
        /// Get all tagged-based badges in alphabetical order. (API Method: "/badges/tags")
        /// </summary>
        Task<StacManResponse<Badge>> GetTagBased(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Badges.Sort? sort = null, Badges.Rank? minrank = null, Badges.Rank? maxrank = null, string minname = null, string maxname = null, Order? order = null, string inname = null);

    }
}

#pragma warning restore 1591
