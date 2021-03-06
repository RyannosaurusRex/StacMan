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
    public partial class InboxItem : StacManType
    {
        internal InboxItem(FilterBehavior filterBehavior, Filter filter) : base(filterBehavior, filter, "inbox_item") { }

        private int? _AnswerId;
        [Field("answer_id")]
        public int? AnswerId
        {
            get { EnsureFilterContainsField("answer_id"); return _AnswerId; }
            internal set { _AnswerId = value; }
        }

        private string _Body;
        [Field("body")]
        public string Body
        {
            get { EnsureFilterContainsField("body"); return _Body; }
            internal set { _Body = value; }
        }

        private int? _CommentId;
        [Field("comment_id")]
        public int? CommentId
        {
            get { EnsureFilterContainsField("comment_id"); return _CommentId; }
            internal set { _CommentId = value; }
        }

        private DateTime _CreationDate;
        [Field("creation_date")]
        public DateTime CreationDate
        {
            get { EnsureFilterContainsField("creation_date"); return _CreationDate; }
            internal set { _CreationDate = value; }
        }

        private bool _IsUnread;
        [Field("is_unread")]
        public bool IsUnread
        {
            get { EnsureFilterContainsField("is_unread"); return _IsUnread; }
            internal set { _IsUnread = value; }
        }

        private InboxItems.ItemType _ItemType;
        [Field("item_type")]
        public InboxItems.ItemType ItemType
        {
            get { EnsureFilterContainsField("item_type"); return _ItemType; }
            internal set { _ItemType = value; }
        }

        private string _Link;
        [Field("link")]
        public string Link
        {
            get { EnsureFilterContainsField("link"); return _Link; }
            internal set { _Link = value; }
        }

        private int? _QuestionId;
        [Field("question_id")]
        public int? QuestionId
        {
            get { EnsureFilterContainsField("question_id"); return _QuestionId; }
            internal set { _QuestionId = value; }
        }

        private Site _Site;
        [Field("site")]
        public Site Site
        {
            get { EnsureFilterContainsField("site"); return _Site; }
            internal set { _Site = value; }
        }

        private string _Title;
        [Field("title")]
        public string Title
        {
            get { EnsureFilterContainsField("title"); return _Title; }
            internal set { _Title = value; }
        }
    }
}

#pragma warning restore 1591
