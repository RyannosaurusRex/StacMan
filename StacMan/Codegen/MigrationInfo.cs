// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

using System;

namespace StackExchange.StacMan
{
    public partial class MigrationInfo : StacManType
    {
        internal MigrationInfo(FilterBehavior filterBehavior, Filter filter) : base(filterBehavior, filter, "migration_info") { }

        private DateTime _OnDate;
        [Field("on_date")]
        public DateTime OnDate
        {
            get { EnsureFilterContainsField("on_date"); return _OnDate; }
            internal set { _OnDate = value; }
        }

        private Site _OtherSite;
        [Field("other_site")]
        public Site OtherSite
        {
            get { EnsureFilterContainsField("other_site"); return _OtherSite; }
            internal set { _OtherSite = value; }
        }

        private int _QuestionId;
        [Field("question_id")]
        public int QuestionId
        {
            get { EnsureFilterContainsField("question_id"); return _QuestionId; }
            internal set { _QuestionId = value; }
        }
    }
}

#pragma warning restore 1591
