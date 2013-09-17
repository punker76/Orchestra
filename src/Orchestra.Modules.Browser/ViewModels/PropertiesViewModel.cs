﻿namespace Orchestra.Modules.Browser.ViewModels
{
    /// <summary>
    /// Backing ViewModel for the PropertiesView
    /// </summary>
    public class PropertiesViewModel : Orchestra.ViewModels.ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesViewModel"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        public PropertiesViewModel(string title)
        {
            if (!string.IsNullOrWhiteSpace(title))
            {
                Title = title;
            }
        }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public string Url { get; set; }
    }
}
