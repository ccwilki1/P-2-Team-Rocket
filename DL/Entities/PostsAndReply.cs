using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class PostsAndReply
    {
        public int PostId { get; set; }
        public int ReplyId { get; set; }
        public int PostReplyId { get; set; }

        public virtual Post Post { get; set; }
        public virtual Reply Reply { get; set; }
    }
}
