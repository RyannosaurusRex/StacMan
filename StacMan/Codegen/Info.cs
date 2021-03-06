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
    public partial class Info : StacManType
    {
        internal Info(FilterBehavior filterBehavior, Filter filter) : base(filterBehavior, filter, "info") { }

        private decimal _AnswersPerMinute;
        [Field("answers_per_minute")]
        public decimal AnswersPerMinute
        {
            get { EnsureFilterContainsField("answers_per_minute"); return _AnswersPerMinute; }
            internal set { _AnswersPerMinute = value; }
        }

        private string _ApiRevision;
        [Field("api_revision")]
        public string ApiRevision
        {
            get { EnsureFilterContainsField("api_revision"); return _ApiRevision; }
            internal set { _ApiRevision = value; }
        }

        private decimal _BadgesPerMinute;
        [Field("badges_per_minute")]
        public decimal BadgesPerMinute
        {
            get { EnsureFilterContainsField("badges_per_minute"); return _BadgesPerMinute; }
            internal set { _BadgesPerMinute = value; }
        }

        private int _NewActiveUsers;
        [Field("new_active_users")]
        public int NewActiveUsers
        {
            get { EnsureFilterContainsField("new_active_users"); return _NewActiveUsers; }
            internal set { _NewActiveUsers = value; }
        }

        private decimal _QuestionsPerMinute;
        [Field("questions_per_minute")]
        public decimal QuestionsPerMinute
        {
            get { EnsureFilterContainsField("questions_per_minute"); return _QuestionsPerMinute; }
            internal set { _QuestionsPerMinute = value; }
        }

        private Site _Site;
        [Field("site")]
        public Site Site
        {
            get { EnsureFilterContainsField("site"); return _Site; }
            internal set { _Site = value; }
        }

        private int _TotalAccepted;
        [Field("total_accepted")]
        public int TotalAccepted
        {
            get { EnsureFilterContainsField("total_accepted"); return _TotalAccepted; }
            internal set { _TotalAccepted = value; }
        }

        private int _TotalAnswers;
        [Field("total_answers")]
        public int TotalAnswers
        {
            get { EnsureFilterContainsField("total_answers"); return _TotalAnswers; }
            internal set { _TotalAnswers = value; }
        }

        private int _TotalBadges;
        [Field("total_badges")]
        public int TotalBadges
        {
            get { EnsureFilterContainsField("total_badges"); return _TotalBadges; }
            internal set { _TotalBadges = value; }
        }

        private int _TotalComments;
        [Field("total_comments")]
        public int TotalComments
        {
            get { EnsureFilterContainsField("total_comments"); return _TotalComments; }
            internal set { _TotalComments = value; }
        }

        private int _TotalQuestions;
        [Field("total_questions")]
        public int TotalQuestions
        {
            get { EnsureFilterContainsField("total_questions"); return _TotalQuestions; }
            internal set { _TotalQuestions = value; }
        }

        private int _TotalUnanswered;
        [Field("total_unanswered")]
        public int TotalUnanswered
        {
            get { EnsureFilterContainsField("total_unanswered"); return _TotalUnanswered; }
            internal set { _TotalUnanswered = value; }
        }

        private int _TotalUsers;
        [Field("total_users")]
        public int TotalUsers
        {
            get { EnsureFilterContainsField("total_users"); return _TotalUsers; }
            internal set { _TotalUsers = value; }
        }

        private int _TotalVotes;
        [Field("total_votes")]
        public int TotalVotes
        {
            get { EnsureFilterContainsField("total_votes"); return _TotalVotes; }
            internal set { _TotalVotes = value; }
        }
    }
}

#pragma warning restore 1591
