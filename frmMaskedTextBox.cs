﻿using System.Windows.Forms;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmMaskedTextBox : Form
    {
        public frmMaskedTextBox()
        {
            InitializeComponent();
        }

        /*
         MaskedTextBox1.Mask = "00/00/0000";  

        Here is a list and description of masking characters.

        0 – Digit, required. Value between 0 and 9.
        9 – Digit or space, optional.
        # - Digit or space, optional. If this position is blank in the mask, it will be rendered as a space in the Text property.
        L - Letter, required. Restricts input to the ASCII letters a-z and A-Z.
        ? - Letter, optional. Restricts input to the ASCII letters a-z and A-Z.
        & - Character, required.
        C - Character, optional. Any non-control character.
        A - Alphanumeric, required.
        a - Alphanumeric, optional.
        . - Decimal placeholder.
        , - Thousands placeholder.
        : - Time separator.
        / - Date separator.
        $ - Currency symbol.
        < - Shift down. Converts all characters that follow to lowercase.
        > - Shift up. Converts all characters that follow to uppercase.
        | - Disable a previous shift up or shift down.
        \ - Escape. Escapes a mask character, turning it into a literal. "\\" is the escape sequence for a backslash.
        All other characters - Literals. All non-mask elements will appear as themselves within MaskedTextBox.
        Literals always occupy a static position in the mask at run time, and cannot be moved or deleted by the user.
        
         */
    }
}
