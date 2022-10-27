using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDataModels.Inputs
{
    public partial class NewProjectModel : ObservableValidator
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Client { get; set; }

        [Required]
        public NewProjectStatus Status { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public NewProjectSource Source { get; set; }

        [ObservableProperty]
        private string _address;

        [Required]
        [ObservableProperty]
        private string _postCode;

        [Required]
        public double Easting;

        [Required]
        public double Northing;

        [Required]
        public string Region { get; set; }

        [Required]
        public string SubRegion { get; set; }

        public NewProjectModel()
        {
            Status = NewProjectStatus.Enquiry;
            Source = NewProjectSource.New;
        }

    }

    public enum NewProjectStatus
    {
        Live,
        Enquiry
    }

    public enum NewProjectCategory
    {
        Other
    }

    public enum NewProjectSource
    {
        Repeat,
        New,
        InternalCompany,
        ExternalCompany
    }
}
