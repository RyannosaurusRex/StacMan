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
    public partial class Tag : StacManType
    {
        internal Tag(FilterBehavior filterBehavior, Filter filter) : base(filterBehavior, filter, "tag") { }

        private int _Count;
        [Field("count")]
        public int Count
        {
            get { EnsureFilterContainsField("count"); return _Count; }
            internal set { _Count = value; }
        }

        private bool _HasSynonyms;
        [Field("has_synonyms")]
        public bool HasSynonyms
        {
            get { EnsureFilterContainsField("has_synonyms"); return _HasSynonyms; }
            internal set { _HasSynonyms = value; }
        }

        private bool _IsModeratorOnly;
        [Field("is_moderator_only")]
        public bool IsModeratorOnly
        {
            get { EnsureFilterContainsField("is_moderator_only"); return _IsModeratorOnly; }
            internal set { _IsModeratorOnly = value; }
        }

        private bool _IsRequired;
        [Field("is_required")]
        public bool IsRequired
        {
            get { EnsureFilterContainsField("is_required"); return _IsRequired; }
            internal set { _IsRequired = value; }
        }

        private DateTime? _LastActivityDate;
        [Field("last_activity_date")]
        public DateTime? LastActivityDate
        {
            get { EnsureFilterContainsField("last_activity_date"); return _LastActivityDate; }
            internal set { _LastActivityDate = value; }
        }

        private string _Name;
        [Field("name")]
        public string Name
        {
            get { EnsureFilterContainsField("name"); return _Name; }
            internal set { _Name = value; }
        }

        private int? _UserId;
        [Field("user_id")]
        public int? UserId
        {
            get { EnsureFilterContainsField("user_id"); return _UserId; }
            internal set { _UserId = value; }
        }
    }
}

#pragma warning restore 1591
