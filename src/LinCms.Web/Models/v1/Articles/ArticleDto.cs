﻿using LinCms.Zero.Common;
using LinCms.Zero.Domain;
using LinCms.Zero.Domain.Blog;
using System;
namespace LinCms.Web.Models.v1.Articles
{
    public class ArticleDto : Entity, ICreateAduitEntity
    {
        //类别Id
        public int? ClassifyId { get; set; }
        //类别名称 
        public string ClassifyName { get; set; }
        //几小时/秒前
        public string TimeSpan => LinCmsUtils.GetTimeDifferNow(this.CreateTime.ToDateTime());

        private readonly DateTime _now = DateTime.Now;
        public bool IsNew => DateTime.Compare(_now.AddDays(-2), this.CreateTime.ToDateTime()) <= 0;

        public string Content { get; set; }
        public string Title { get; set; }
        public string Keywords { get; set; }
        public string Source { get; set; }
        public string Excerpt { get; set; }
        public int ViewHits { get; set; }
        public int CommentQuantity { get; set; }
        public int PointQuantity { get; set; }
        public string Thumbnail { get; set; }
        public string ThumbnailDisplay { get; set; }
        public bool IsAudit { get; set; }
        public bool Recommend { get; set; }
        public bool IsStickie { get; set; }
        public string Archive { get; set; }
        public ArticleType ArticleType { get; set; }
        public int Editor { get; set; } = 1;
        public long? CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public string Author { get; set; }
    }
}
