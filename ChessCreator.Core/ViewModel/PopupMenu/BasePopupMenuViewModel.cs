
using ChessCreator.Core;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ChessCreator
{
    /// <summary>
    /// A view model for the any popup menus
    /// </summary>
    public class BasePopupMenuViewModel : BaseViewModel
    {
       
        #region Public Properties

        /// <summary>
        /// The background color of the bubble in ARGB value
        /// </summary>
        public string BubbleBackground { get; set; }

        /// <summary>
        /// The alignment of the bubble arrow
        /// </summary>
        public ElementHorizontalAlignment ArrowAlignment { get; set; }

        #endregion Public Properties

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public BasePopupMenuViewModel()
        {
            // Set default values
            BubbleBackground = "ffffff";
            ArrowAlignment = ElementHorizontalAlignment.Left;
        }

        #endregion Constructor
    }
}
