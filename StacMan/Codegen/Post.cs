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
    public partial class Post : StacManType
    {
        internal Post(FilterBehavior filterBehavior, Filter filter) : base(filterBehavior, filter, "post") { }

        private string _Body;
        [Field("body")]
        public string Body
        {
            get { EnsureFilterContainsField("body"); return _Body; }
            internal set { _Body = value; }
        }

        private Comment[] _Comments;
        [Field("comments")]
        public Comment[] Comments
        {
            get { EnsureFilterContainsField("comments"); return _Comments; }
            internal set { _Comments = value; }
        }

        private DateTime _CreationDate;
        [Field("creation_date")]
        public DateTime CreationDate
        {
            get { EnsureFilterContainsField("creation_date"); return _CreationDate; }
            internal set { _CreationDate = value; }
        }

        private int _DownVoteCount;
        [Field("down_vote_count")]
        public int DownVoteCount
        {
            get { EnsureFilterContainsField("down_vote_count"); return _DownVoteCount; }
            internal set { _DownVoteCount = value; }
        }

        private DateTime _LastActivityDate;
        [Field("last_activity_date")]
        public DateTime LastActivityDate
        {
            get { EnsureFilterContainsField("last_activity_date"); return _LastActivityDate; }
            internal set { _LastActivityDate = value; }
        }

        private DateTime? _LastEditDate;
        [Field("last_edit_date")]
        public DateTime? LastEditDate
        {
            get { EnsureFilterContainsField("last_edit_date"); return _LastEditDate; }
            internal set { _LastEditDate = value; }
        }

        private ShallowUser _Owner;
        [Field("owner")]
        public ShallowUser Owner
        {
            get { EnsureFilterContainsField("owner"); return _Owner; }
            internal set { _Owner = value; }
        }

        private int _PostId;
        [Field("post_id")]
        public int PostId
        {
            get { EnsureFilterContainsField("post_id"); return _PostId; }
            internal set { _PostId = value; }
        }

        private Posts.PostType _PostType;
        [Field("post_type")]
        public Posts.PostType PostType
        {
            get { EnsureFilterContainsField("post_type"); return _PostType; }
            internal set { _PostType = value; }
        }

        private int _Score;
        [Field("score")]
        public int Score
        {
            get { EnsureFilterContainsField("score"); return _Score; }
            internal set { _Score = value; }
        }

        private int _UpVoteCount;
        [Field("up_vote_count")]
        public int UpVoteCount
        {
            get { EnsureFilterContainsField("up_vote_count"); return _UpVoteCount; }
            internal set { _UpVoteCount = value; }
        }
    }
}

#pragma warning restore 1591
