using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ChessCreator
{
    /// <summary>
    /// Logica di interazione per PageHost.xaml
    /// </summary>
    public partial class PageHost : UserControl
    {
        #region Dependency Properties

        #endregion Dependency Properties
        /// <summary>
        /// The current page to show in the page host
        /// </summary>
        public BasePage CurrentPage
        {
            get => (BasePage)GetValue(CurrentPageProperty);
            set => SetValue(CurrentPageProperty, value);
        }

        /// <summary>
        /// Registers <see cref="CurrentPage"/> as a dependency property
        /// </summary>
        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register(nameof(CurrentPage), typeof(BasePage), typeof(PageHost),
                new UIPropertyMetadata(CurrentPagePropertyChanged));




        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public PageHost()
        {
            InitializeComponent();

        }

        #endregion Constructor

        #region Property Changed Events

        /// <summary>
        /// Called when the <see cref="CurrentPage"/> value as changed  
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void CurrentPagePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

            // Get the frames
            var newPageFrame = (d as PageHost).NewPage;
            var oldPageFrame = (d as PageHost).OldPage;

            // Store the current page content as the old page
            var oldPageContent = newPageFrame.Content;

            // Remove page from new page frame
            newPageFrame.Content = null;

            // Move the current page into the old page frame
            oldPageFrame.Content = oldPageContent;

            // Animate out previous page when the loaded event fires 
            // right afther this call due to moving frames
            if (oldPageContent is BasePage oldPage)
                oldPage.ShouldAnimateOut = true;

            // Set the new page content
            newPageFrame.Content = e.NewValue;
        }
        #endregion Property Changed Events
    }
}
