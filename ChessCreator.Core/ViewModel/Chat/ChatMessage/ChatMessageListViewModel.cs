using System.Collections.Generic;
using System.Windows.Input;

namespace ChessCreator.Core
{
    /// <summary>
    /// A view model for the overview chat message list
    /// </summary>
    public class ChatMessageListViewModel : BaseViewModel
    {
        #region Public properties

        /// <summary>
        /// The chat list items for the list
        /// </summary>
        public List<ChatMessageListItemViewModel> Items { get; set; }

        /// <summary>
        /// True to show the attachment menu, false to hide it
        /// </summary>
        public bool AttachmentMenuVisible { get; set; }

        public ChatAttachmentPopupMenuViewModel AttachmentMenu { get; set; }

        #endregion Public properties

        #region Public command

        /// <summary>
        /// The command for when the attacment button is clicked
        /// </summary>
        public ICommand AttachmentButtonCommand { get; set; }

        #endregion Public command

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatMessageListViewModel()
        {
            // Create commands
            AttachmentButtonCommand = new RelayCommand(AttachmentButton);

            //Make a default menu
            AttachmentMenu = new ChatAttachmentPopupMenuViewModel();
        }
        #endregion Constructor

        #region Command methods

        /// <summary>
        /// when the attachment button is clicked show/hide the attachment popup
        /// </summary>
        public void AttachmentButton()
        {
            // Toggle menu visibility 
            AttachmentMenuVisible ^= true;
        }

        #endregion
    }
}
