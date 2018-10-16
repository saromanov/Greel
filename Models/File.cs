namespace Greel.Models {
    public class FileUpload {
        [Required]
        [Display(Name="Title")]
        [StringLength(64, MinimumLength = 2)]
        public string Title { get; set; }

        [Required]
        [Display(Name="Type")]
        public string Type {get; set; }
    }
}