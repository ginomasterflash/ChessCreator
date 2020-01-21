
using ChessCreator.Core;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ChessCreator.Core
{
    /// <summary>
    /// A design time data for a <see cref="ChattachmentPopupMenuViewModel"/>
    /// </summary>
    public class ChatAttachmentPopupMenuDesignModel : ChatAttachmentPopupMenuViewModel
    {

        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatAttachmentPopupMenuViewModel Instance => new ChatAttachmentPopupMenuViewModel();

        #endregion Singleton

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ChatAttachmentPopupMenuDesignModel()
        {
        }

        #endregion Constructor
    }

}
