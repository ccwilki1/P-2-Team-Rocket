using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Reply
    {
        public Reply()
        {
            PostsAndReplies = new HashSet<PostsAndReply>();
        }

        public string ReplyText { get; set; }
        public string DateCreated { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public int ReplyId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<PostsAndReply> PostsAndReplies { get; set; }
    }
}
