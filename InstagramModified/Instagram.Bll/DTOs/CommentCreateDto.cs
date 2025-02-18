﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Bll.DTOs;

public class CommentCreateDto
{
    public string Body { get; set; }

    public long AccauntId { get; set; }
    public long PostId { get; set; }
    public long? ParentCommentId { get; set; }
}
