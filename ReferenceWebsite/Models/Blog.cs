﻿using System;
using UmbracoVault.Attributes;

namespace ReferenceWebsite.Models
{
    [UmbracoMediaEntity(AutoMap = true, Alias = "BlogEntry")]
    public class BlogEntryViewModel : CmsViewModelBase, IBlogEntryViewModel
    {
        public virtual string Title { get; set; }
        public virtual DateTime? PostDate { get; set; }
        [UmbracoRichTextProperty]
        string IBlogEntryViewModel.Content { get; set; }
        [UmbracoProperty(Alias = "image")]
        public virtual Image PostImage { get; set; }
    }

    [UmbracoEntity(AutoMap = true, Alias = "BlogHome")]
    public class BlogHomeViewModel : CmsViewModelBase
    {
        public string Title { get; set; }
        public string SidebarCopy { get; set; }
        public BlogEntryViewModel FeaturedBlogEntry { get; set; }
    }

    public interface IBlogEntryViewModel
    {
        string Title { get; set; }
        DateTime? PostDate { get; set; }
        string Content { get; set; }
    }

}