using System.ComponentModel.DataAnnotations;

namespace WebAPI.Services.Common
{
    public enum Statuses
    {
        None,
        [Display(Name = "Draft")]
        Draft,
        [Display(Name = "Submit")]
        Submit,
        [Display(Name = "Ammend")]
        Ammend,
        [Display(Name = "Approve")]
        Approve,
        [Display(Name = "Reject")]
        Reject
    }

    public enum TaggingTypes
    {
        [Display(Name = "Save")]
        Save,
        [Display(Name = "View")]
        View,
        [Display(Name = "Like")]
        Like,
        [Display(Name = "Share")]
        Share
    }

    public enum AppConfiguration
    {
        [Display(Name = "SkipShareDocumentDialog")]
        SkipShareDocumentDialog
    }

    public enum FileTypeSupport
    {
        [Display(Name = "jpeg")]
        Jpg,
        [Display(Name = "png")]
        Png
    }

    public enum KdState
    {
        None,
        [Display(Name = "Build")]
        Build,
        [Display(Name = "Validate")]
        Validate,
        [Display(Name = "Submit")]
        Submit
    }

    public enum SortOrder
    {
        [Display(Name = "asc")]
        Asc,
        [Display(Name = "desc")]
        Desc,
        [Display(Name = "none")]
        None
    }

    public enum DateGroupType
    {
        Day,
        Week,
        Month,
        Quarter,
        Year
    }
}
