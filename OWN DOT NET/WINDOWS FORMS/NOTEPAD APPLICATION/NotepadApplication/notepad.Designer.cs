namespace NotepadApplication
{
    partial class notepad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notepad));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.btnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFind = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFindPrevious = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGoTo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTimeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFont = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlignment = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLeftAlignment = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCenterAlignment = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRightAlignment = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBullets = new System.Windows.Forms.ToolStripMenuItem();
            this.bthYesBullet = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNoBullet = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToSpeechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearchWithGoogle = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAboutNotepad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRestoreDefaultZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.btnRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile,
            this.btnEdit,
            this.btnFormat,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1056, 37);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnOpen,
            this.btnSave,
            this.toolStripSeparator1,
            this.btnSaveas,
            this.btnPageSetup,
            this.btnPrintPreview,
            this.btnPrint,
            this.btnExit});
            this.btnFile.Font = new System.Drawing.Font("Calibri Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(59, 31);
            this.btnFile.Text = "&File";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNew.Name = "btnNew";
            this.btnNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnNew.Size = new System.Drawing.Size(270, 36);
            this.btnNew.Text = "&New";
            this.btnNew.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnOpen.Size = new System.Drawing.Size(270, 36);
            this.btnOpen.Text = "&Open";
            this.btnOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.Name = "btnSave";
            this.btnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSave.Size = new System.Drawing.Size(270, 36);
            this.btnSave.Text = "&Save";
            // 
            // btnSaveas
            // 
            this.btnSaveas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveas.Name = "btnSaveas";
            this.btnSaveas.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.btnSaveas.Size = new System.Drawing.Size(270, 36);
            this.btnSaveas.Text = "&Save as";
            // 
            // btnPageSetup
            // 
            this.btnPageSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPageSetup.Name = "btnPageSetup";
            this.btnPageSetup.Size = new System.Drawing.Size(270, 36);
            this.btnPageSetup.Text = "&Page Setup";
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(270, 36);
            this.btnPrintPreview.Text = "&Print Preview";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.btnPrint.Size = new System.Drawing.Size(270, 36);
            this.btnPrint.Text = "&Print";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.Name = "btnExit";
            this.btnExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.btnExit.Size = new System.Drawing.Size(270, 36);
            this.btnExit.Text = "&Exit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // btnEdit
            // 
            this.btnEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.btnRedo,
            this.toolStripSeparator2,
            this.btnCut,
            this.btnCopy,
            this.btnPaste,
            this.btnDelete,
            this.toolStripSeparator3,
            this.btnFind,
            this.btnFindNext,
            this.btnFindPrevious,
            this.btnReplace,
            this.btnGoTo,
            this.toolStripSeparator4,
            this.btnSelectAll,
            this.btnTimeDate});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(58, 31);
            this.btnEdit.Text = "&Edit";
            this.btnEdit.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // btnCut
            // 
            this.btnCut.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCut.Name = "btnCut";
            this.btnCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.btnCut.Size = new System.Drawing.Size(270, 34);
            this.btnCut.Text = "Cut";
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.btnCopy.Size = new System.Drawing.Size(270, 34);
            this.btnCopy.Text = "Copy";
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.btnPaste.Size = new System.Drawing.Size(270, 34);
            this.btnPaste.Text = "Paste";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.btnDelete.Size = new System.Drawing.Size(270, 34);
            this.btnDelete.Text = "Delete";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFind.Name = "btnFind";
            this.btnFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.btnFind.Size = new System.Drawing.Size(270, 34);
            this.btnFind.Text = "Find";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(267, 6);
            // 
            // btnFindNext
            // 
            this.btnFindNext.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.btnFindNext.Size = new System.Drawing.Size(270, 34);
            this.btnFindNext.Text = "Find Next";
            // 
            // btnFindPrevious
            // 
            this.btnFindPrevious.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFindPrevious.Name = "btnFindPrevious";
            this.btnFindPrevious.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.btnFindPrevious.Size = new System.Drawing.Size(270, 34);
            this.btnFindPrevious.Text = "Find Previous";
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.btnReplace.Size = new System.Drawing.Size(270, 34);
            this.btnReplace.Text = "Replace";
            // 
            // btnGoTo
            // 
            this.btnGoTo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.btnGoTo.Size = new System.Drawing.Size(270, 34);
            this.btnGoTo.Text = "Go To...";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.btnSelectAll.Size = new System.Drawing.Size(270, 34);
            this.btnSelectAll.Text = "Select All";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(267, 6);
            // 
            // btnTimeDate
            // 
            this.btnTimeDate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTimeDate.Name = "btnTimeDate";
            this.btnTimeDate.Size = new System.Drawing.Size(270, 34);
            this.btnTimeDate.Text = "Time / Date";
            // 
            // btnFormat
            // 
            this.btnFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnWordWrap,
            this.btnFont,
            this.btnFontColor,
            this.btnBackgroundColor,
            this.btnAlignment,
            this.btnBullets});
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(85, 31);
            this.btnFormat.Text = "F&ormat";
            // 
            // btnWordWrap
            // 
            this.btnWordWrap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnWordWrap.Name = "btnWordWrap";
            this.btnWordWrap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.btnWordWrap.Size = new System.Drawing.Size(352, 34);
            this.btnWordWrap.Text = "Word Wrap";
            // 
            // btnFont
            // 
            this.btnFont.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFont.Name = "btnFont";
            this.btnFont.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.btnFont.Size = new System.Drawing.Size(352, 34);
            this.btnFont.Text = "Font";
            // 
            // btnFontColor
            // 
            this.btnFontColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F)));
            this.btnFontColor.Size = new System.Drawing.Size(352, 34);
            this.btnFontColor.Text = "Font Color";
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.B)));
            this.btnBackgroundColor.Size = new System.Drawing.Size(352, 34);
            this.btnBackgroundColor.Text = "Background Color";
            // 
            // btnAlignment
            // 
            this.btnAlignment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAlignment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLeftAlignment,
            this.btnCenterAlignment,
            this.btnRightAlignment});
            this.btnAlignment.Name = "btnAlignment";
            this.btnAlignment.Size = new System.Drawing.Size(352, 34);
            this.btnAlignment.Text = "Alignment";
            // 
            // btnLeftAlignment
            // 
            this.btnLeftAlignment.Name = "btnLeftAlignment";
            this.btnLeftAlignment.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.btnLeftAlignment.Size = new System.Drawing.Size(275, 34);
            this.btnLeftAlignment.Text = "Left";
            // 
            // btnCenterAlignment
            // 
            this.btnCenterAlignment.Name = "btnCenterAlignment";
            this.btnCenterAlignment.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.btnCenterAlignment.Size = new System.Drawing.Size(275, 34);
            this.btnCenterAlignment.Text = "Center";
            // 
            // btnRightAlignment
            // 
            this.btnRightAlignment.Name = "btnRightAlignment";
            this.btnRightAlignment.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.btnRightAlignment.Size = new System.Drawing.Size(275, 34);
            this.btnRightAlignment.Text = "Right";
            // 
            // btnBullets
            // 
            this.btnBullets.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBullets.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bthYesBullet,
            this.btnNoBullet});
            this.btnBullets.Name = "btnBullets";
            this.btnBullets.Size = new System.Drawing.Size(352, 34);
            this.btnBullets.Text = "Bullets";
            // 
            // bthYesBullet
            // 
            this.bthYesBullet.Name = "bthYesBullet";
            this.bthYesBullet.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Y)));
            this.bthYesBullet.Size = new System.Drawing.Size(270, 34);
            this.bthYesBullet.Text = "Yes";
            // 
            // btnNoBullet
            // 
            this.btnNoBullet.Name = "btnNoBullet";
            this.btnNoBullet.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.N)));
            this.btnNoBullet.Size = new System.Drawing.Size(270, 34);
            this.btnNoBullet.Text = "No";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnZoom,
            this.statusBarToolStripMenuItem,
            this.textToSpeechToolStripMenuItem,
            this.btnSearchWithGoogle});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 31);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // btnZoom
            // 
            this.btnZoom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnZoomIn,
            this.btnZoomOut,
            this.btnRestoreDefaultZoom});
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(271, 34);
            this.btnZoom.Text = "Zoom";
            this.btnZoom.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.statusBarToolStripMenuItem.Text = "Status Bar";
            // 
            // textToSpeechToolStripMenuItem
            // 
            this.textToSpeechToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textToSpeechToolStripMenuItem.Name = "textToSpeechToolStripMenuItem";
            this.textToSpeechToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.textToSpeechToolStripMenuItem.Text = "Text to Speech";
            // 
            // btnSearchWithGoogle
            // 
            this.btnSearchWithGoogle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearchWithGoogle.Name = "btnSearchWithGoogle";
            this.btnSearchWithGoogle.Size = new System.Drawing.Size(271, 34);
            this.btnSearchWithGoogle.Text = "Search With Google";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewHelp,
            this.btnAboutNotepad});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 31);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // btnViewHelp
            // 
            this.btnViewHelp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnViewHelp.Name = "btnViewHelp";
            this.btnViewHelp.Size = new System.Drawing.Size(270, 34);
            this.btnViewHelp.Text = "View Help";
            // 
            // btnAboutNotepad
            // 
            this.btnAboutNotepad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAboutNotepad.Name = "btnAboutNotepad";
            this.btnAboutNotepad.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
            this.btnAboutNotepad.Size = new System.Drawing.Size(336, 34);
            this.btnAboutNotepad.Text = "About Notepad";
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Up)));
            this.btnZoomIn.Size = new System.Drawing.Size(304, 34);
            this.btnZoomIn.Text = "Zoom In";
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Down)));
            this.btnZoomOut.Size = new System.Drawing.Size(397, 34);
            this.btnZoomOut.Text = "Zoom Out";
            // 
            // btnRestoreDefaultZoom
            // 
            this.btnRestoreDefaultZoom.Name = "btnRestoreDefaultZoom";
            this.btnRestoreDefaultZoom.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.btnRestoreDefaultZoom.Size = new System.Drawing.Size(397, 34);
            this.btnRestoreDefaultZoom.Text = "Restore Default Zoom";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1056, 529);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripDropDownButton1,
            this.toolStripSplitButton1});
            this.statusStrip.Location = new System.Drawing.Point(0, 534);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1056, 32);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 24);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(42, 29);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(45, 29);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.btnRedo.Size = new System.Drawing.Size(270, 34);
            this.btnRedo.Text = "Redo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(267, 6);
            // 
            // notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 566);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "notepad";
            this.Text = "NOTEPAD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnFile;
        private System.Windows.Forms.ToolStripMenuItem btnNew;
        private System.Windows.Forms.ToolStripMenuItem btnOpen;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnSaveas;
        private System.Windows.Forms.ToolStripMenuItem btnPageSetup;
        private System.Windows.Forms.ToolStripMenuItem btnPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem btnPrint;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCut;
        private System.Windows.Forms.ToolStripMenuItem btnCopy;
        private System.Windows.Forms.ToolStripMenuItem btnPaste;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem btnFind;
        private System.Windows.Forms.ToolStripMenuItem btnFindNext;
        private System.Windows.Forms.ToolStripMenuItem btnFindPrevious;
        private System.Windows.Forms.ToolStripMenuItem btnReplace;
        private System.Windows.Forms.ToolStripMenuItem btnGoTo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem btnSelectAll;
        private System.Windows.Forms.ToolStripMenuItem btnTimeDate;
        private System.Windows.Forms.ToolStripMenuItem btnFormat;
        private System.Windows.Forms.ToolStripMenuItem btnWordWrap;
        private System.Windows.Forms.ToolStripMenuItem btnFont;
        private System.Windows.Forms.ToolStripMenuItem btnFontColor;
        private System.Windows.Forms.ToolStripMenuItem btnBackgroundColor;
        private System.Windows.Forms.ToolStripMenuItem btnAlignment;
        private System.Windows.Forms.ToolStripMenuItem btnLeftAlignment;
        private System.Windows.Forms.ToolStripMenuItem btnCenterAlignment;
        private System.Windows.Forms.ToolStripMenuItem btnRightAlignment;
        private System.Windows.Forms.ToolStripMenuItem btnBullets;
        private System.Windows.Forms.ToolStripMenuItem bthYesBullet;
        private System.Windows.Forms.ToolStripMenuItem btnNoBullet;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnZoom;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToSpeechToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSearchWithGoogle;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnViewHelp;
        private System.Windows.Forms.ToolStripMenuItem btnAboutNotepad;
        private System.Windows.Forms.ToolStripMenuItem btnZoomIn;
        private System.Windows.Forms.ToolStripMenuItem btnZoomOut;
        private System.Windows.Forms.ToolStripMenuItem btnRestoreDefaultZoom;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.ToolStripMenuItem btnRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

