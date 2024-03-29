internal static Dictionary<string, string> ReplaceResources(ResourceManager rm) {
         var resourcesOriginal = new Dictionary<string, string>() {
            { "TX_MENU_ANNOTATE_ADDHIGHLIGHT", "Adds a highlight to the document." },
            { "TX_MENU_ANNOTATE_STAMP", "Adds a stamp at the current location." },
            { "TX_MENU_ANNOTATE_ADDCOMMENT", "Adds a comment to the current location." },
            { "TX_MENU_ANNOTATE_BOLD", "Sets the text style to bold." },
            { "TX_MENU_ANNOTATE_ITALIC", "Sets the text style to italic." },
            { "TX_MENU_ANNOTATE_UNDERLINE", "Sets the text style to underline." },
            { "TX_MENU_ANNOTATE_STRIKE", "Sets the text style to strike through." },
            { "TX_MENU_ANNOTATE_TEXTSTYLE", "Modify the text formatting." },
            { "TX_MENU_ANNOTATE_DRAWTEXT", "Inserts text into the document." },
            { "TX_FORMS_BOX", "This document contains form fields." },
            { "TX_FORMS_BOX_BTN_TEXT", "Go to form" },
            { "TX_FORMS_BOX_BTN_TITLE", "Jump to the first field to complete those fields." },
            { "TX_MENU_ANNOTATE_COMMENTS", "Toggle comments sidebar" },
            { "TX_MENU_ANNOTATE_DELETE", "Delete annotation" },
            { "TX_MENU_ANNOTATE_SELECT", "Select annotation" },
            { "TX_MENU_ANNOTATE_STYLE", "Open the annotation style dialog box" },
            { "TX_MENU_ANNOTATE_OPEN", "Toggle the annotation toolbar" },
            { "TX_MENU_ANNOTATE_UNDO", "Undo last action" },
            { "TX_MENU_ANNOTATE_HIGHLIGHT", "Highlight text" },
            { "TX_MENU_ANNOTATE_DRAW", "Annotate with pen" },
            { "TX_MENU_ANNOTATE_MARK", "Annotate with marker" },
            { "TX_MENU_ANNOTATE_ERASER", "Erase marker lines" },
            { "TX_MENU_ANNOTATE_CLEARALL", "Clear all annotations" },
            { "TX_PAGE_SELECTOR_BACK", "Previous page" },
            { "TX_PAGE_SELECTOR_NEXT", "Next page" },
            { "TX_MENU_ZOOMPAGEWIDTH", "Zoom to the page's width." },
            { "TX_MENU_ZOOMIN", "Zoom in" },
            { "TX_MENU_ZOOMOUT", "Zoom out" },
            { "TX_MENU_MOVE", "Pan around the document" },
            { "TX_SIGNATURE_TOOLBAR_AUTOADJUST", "Auto adjust signature image" },
            { "TX_SIGNATURE_TOOLBAR_SATURATION", "Make all remaining pixels black" },
            { "TX_SIGNATURE_TOOLBAR_CONTRAST", "Increase contrast" },
            { "TX_SIGNATURE_TOOLBAR_CONTRASTBACK", "Decrease contrast" },
            { "TX_SIGNATURE_TOOLBAR_REMOVEBACKGROUND", "Remove background" },
            { "TX_SIGNATURE_SETUP_SIGNATURE_UPLOAD", "Upload" },
            { "TX_SIGNATURE_SETUP_SIGNATURE_RESTORE", "Restore" },
            { "TX_SIGNATURE_GREETING", "asked you to review and sign this document" },
            { "TX_SIGNATURE_GREETING_NEXT", "To start the process of signing this document, please click 'Next'" },
            { "TX_SIGNATURE_GREETING_NEXT_BTN_TEXT", "Next" },
            { "TX_SIGNATURE_GREETING_NEXT_BTN_TITLE", "Click 'Next' to continue" },
            { "TX_SIGNATURE_ADD_TITLE", "Add Signature" },
            { "TX_SIGNATURE_ADD_SIGNATURE_DESCRIPTION", "DRAW YOUR SIGNATURE" },
            { "TX_SIGNATURE_ADD_SIGNATURE_BTN_START_TEXT", "Add" },
            { "TX_SIGNATURE_ADD_SIGNATURE_BTN_START_TITLE", "Adds the signature." },
            { "TX_SIGNATURE_ADD_SIGNATURE_BTN_CANCEL_TEXT", "Cancel" },
            { "TX_SIGNATURE_ADD_SIGNATURE_BTN_CANCEL_TITLE", "Cancel the signature adding." },
            { "TX_SIGNATURE_SETUP_TITLE", "Setup your Signature" },
            { "TX_SIGNATURE_SETUP_INSTRUCTIONS", "Confirm your name, initials and your signature" },
            { "TX_SIGNATURE_SETUP_NAME", "Full Name" },
            { "TX_SIGNATURE_SETUP_NAME_PLACEHOLDER", "Your full name" },
            { "TX_SIGNATURE_SETUP_INITIALS", "Initials" },
            { "TX_SIGNATURE_SETUP_INITIALS_PLACEHOLDER", "Your initials" },
            { "TX_SIGNATURE_SETUP_SIGNATURE_DESCRIPTION", "DRAW YOUR SIGNATURE" },
            { "TX_SIGNATURE_SETUP_SIGNATURE_CLEAR", "Clear" },
            { "TX_SIGNATURE_SETUP_SIGNATURE_LEGAL", "By clicking 'Setup and Sign', I confirm that the signature is the electronic representation of my signature for all purposes when I use them on documents, including legally binding contracts - just the same as a wet ink signature or initial" },
            { "TX_SIGNATURE_SETUP_SIGNATURE_BTN_START_TEXT", "Setup and Sign" },
            { "TX_SIGNATURE_SETUP_SIGNATURE_BTN_START_TITLE", "Start the signing process" },
            { "TX_SIGNATURE_SETUP_SIGNATURE_BTN_CANCEL_TEXT", "Cancel" },
            { "TX_SIGNATURE_SETUP_SIGNATURE_BTN_CANCEL_TITLE", "Cancel the setup" },
            { "TX_SIGNATURE_SUBMIT_TITLE", "Submit your Signed Document" },
            { "TX_SIGNATURE_SUBMIT_INSTRUCTIONS", "You signed all required signature areas successfully. In order to submit the document with your legally binding signature, please click 'Submit'." },
            { "TX_SIGNATURE_SUBMIT_BTN_SUBMIT_TEXT", "Submit" },
            { "TX_SIGNATURE_SUBMIT_BTN_SUBMIT_TITLE", "Submit the signed document" },
            { "TX_SIGNATURE_SUBMIT_BTN_CANCEL_TEXT", "Cancel" },
            { "TX_SIGNATURE_SUBMIT_BTN_CANCEL_TITLE", "Cancel" },
            { "TX_SIGNATURE_ERROR_TITLE", "An Error Occured on Signing" },
            { "TX_SIGNATURE_ERROR_DESCRIPTION", "An error occured on signing your document. Please try it again later." },
            { "TX_SIGNATURE_ERROR_BTN_SUBMIT_TEXT", "Submit Again" },
            { "TX_SIGNATURE_ERROR_BTN_SUBMIT_TITLE", "Submit the signed document" },
            { "TX_SIGNATURE_ERROR_BTN_CANCEL_TEXT", "Cancel" },
            { "TX_SIGNATURE_ERROR_BTN_CANCEL_TITLE", "Cancel" },
            { "TX_SIGNATURE_CONFIRM_TITLE", "Please confirm your signature by clicking the yellow signature areas." },
            { "TX_SIGNATURE_DONE_TITLE", "The signing process is complete. Please submit your signed document." },
            { "TX_SIGNATURE_DONE_FLAG_TEXT", "Done" },
            { "TX_SIGNATURE_DONE_FLAG_SIGN_TEXT", "Sign here" },
            { "TX_SIGNATURE_DONE_BTN_TEXT", "Submit" },
            { "TX_SIGNATURE_DONE_BTN_TITLE", "Submit your signed document" },
            { "TX_PAGE", "PAGE" },
            { "TX_PAGE_OF", "OF" },
            { "TX_LOCKZOOM", "Lock zoom" },
            { "TX_MENU_SHOWSIDEBAR_TITLE", "Show and hide thumbnail sidebar" },
            { "TX_MENU_ENABLESELECTION_TITLE", "Enable and disable document selection" },
            { "TX_MENU_ENABLEFULLSCREEN_TITLE", "Enable and disable full screen mode" },
            { "TX_MENU_PRINT_TITLE", "Print the document" },
            { "TX_MENU_DOWNLOAD_TITLE", "Download the document as PDF" },
            { "TX_MENU_FIND_TITLE", "Find strings in the document" },
            { "TX_MENU_FIND_PLACEHOLDER", "Search..." },
            { "TX_MENU_FIND_NEXT_TITLE", "Next search entry" },
            { "TX_MENU_FIND_PREVIOUS_TITLE", "Previous search entry" },
            { "TX_MENU_FIND_CANCEL_TITLE", "Cancel search" },
            { "TX_MENU_TWOPAGEVIEW_TITLE", "Toggle two page mode" },
            { "TX_SIDEBAR_HEADER", "Comments" },
            { "TX_SIDEBAR_CLOSE_TITLE", "Close" },
            { "TX_MENU_EDIT_EDITANNOTATIONS_TEXT", "Comment" },
            { "TX_MENU_EDIT_FILLANDSIGN_TEXT", "Fill and Sign" },
            { "TX_MENU_EDIT_REVIEWTRACKEDCHANGES_TEXT", "Review" },
            { "TX_MENU_TRACKEDCHANGES_GOTOFIRST", "First Change" },
            { "TX_MENU_TRACKEDCHANGES_GOTOPREVIOUS", "Previous Change" },
            { "TX_MENU_TRACKEDCHANGES_GOTONEXT", "Next Change" },
            { "TX_MENU_TRACKEDCHANGES_GOTOLAST", "Last Change" },
            { "TX_MENU_TRACKEDCHANGES_ACCEPT", "Accept and Move to Next" },
            { "TX_MENU_TRACKEDCHANGES_REJECT", "Reject and Move to Next" },
            { "TX_MENU_TRACKEDCHANGE_OPEN", "Toggle the tracked changes toolbar" }
         };
