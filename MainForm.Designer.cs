namespace DanbooruNameTagger
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tagSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            composedName = new TextBox();
            label3 = new Label();
            tagList = new ListBoxEx();
            nameSpacesCheck = new CheckBox();
            btnComposedNameCopy = new Button();
            panel1 = new Panel();
            btnRename = new Button();
            panel2 = new Panel();
            pictureViewer = new PictureBox();
            panel3 = new Panel();
            groupNav = new GroupBox();
            btnPicturePrevious = new Button();
            btnPictureNext = new Button();
            groupZoom = new GroupBox();
            btnPictureZoomOut = new Button();
            btnPictureZoomReset = new Button();
            btnPictureZoomIn = new Button();
            labelNewName = new Label();
            label6 = new Label();
            labelCurrentName = new Label();
            label4 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openPictureToolStripMenuItem = new ToolStripMenuItem();
            openFolderToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            btnReset = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureViewer).BeginInit();
            panel3.SuspendLayout();
            groupNav.SuspendLayout();
            groupZoom.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tagSearch
            // 
            tagSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tagSearch.Location = new Point(26, 37);
            tagSearch.Name = "tagSearch";
            tagSearch.Size = new Size(120, 23);
            tagSearch.TabIndex = 0;
            tagSearch.KeyDown += tagSearch_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 19);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter tag to add";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 74);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Added tags";
            // 
            // composedName
            // 
            composedName.Location = new Point(26, 271);
            composedName.Name = "composedName";
            composedName.ReadOnly = true;
            composedName.Size = new Size(166, 23);
            composedName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 253);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 5;
            label3.Text = "Current tags name";
            // 
            // tagList
            // 
            tagList.FormattingEnabled = true;
            tagList.ItemHeight = 15;
            tagList.Location = new Point(26, 92);
            tagList.Name = "tagList";
            tagList.Size = new Size(120, 124);
            tagList.Sorted = true;
            tagList.TabIndex = 1;
            tagList.ItemsChanged += tagList_ItemsChanged;
            tagList.DoubleClick += tagList_DoubleClick;
            // 
            // nameSpacesCheck
            // 
            nameSpacesCheck.AutoSize = true;
            nameSpacesCheck.Location = new Point(26, 221);
            nameSpacesCheck.Name = "nameSpacesCheck";
            nameSpacesCheck.Size = new Size(62, 19);
            nameSpacesCheck.TabIndex = 6;
            nameSpacesCheck.Text = "Spaces";
            nameSpacesCheck.UseVisualStyleBackColor = true;
            nameSpacesCheck.CheckedChanged += nameSpacesCheck_CheckedChanged;
            // 
            // btnComposedNameCopy
            // 
            btnComposedNameCopy.BackgroundImage = Properties.Resources.copy;
            btnComposedNameCopy.BackgroundImageLayout = ImageLayout.Center;
            btnComposedNameCopy.FlatStyle = FlatStyle.Flat;
            btnComposedNameCopy.ImageAlign = ContentAlignment.TopCenter;
            btnComposedNameCopy.Location = new Point(198, 271);
            btnComposedNameCopy.Name = "btnComposedNameCopy";
            btnComposedNameCopy.Size = new Size(32, 23);
            btnComposedNameCopy.TabIndex = 7;
            btnComposedNameCopy.UseVisualStyleBackColor = true;
            btnComposedNameCopy.Click += btnComposedNameCopy_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnRename);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnComposedNameCopy);
            panel1.Controls.Add(tagSearch);
            panel1.Controls.Add(nameSpacesCheck);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tagList);
            panel1.Controls.Add(composedName);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 394);
            panel1.TabIndex = 8;
            // 
            // btnRename
            // 
            btnRename.Location = new Point(26, 343);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(75, 23);
            btnRename.TabIndex = 8;
            btnRename.Text = "&Rename";
            btnRename.UseVisualStyleBackColor = true;
            btnRename.Click += btnRename_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(pictureViewer);
            panel2.Location = new Point(266, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(556, 394);
            panel2.TabIndex = 9;
            // 
            // pictureViewer
            // 
            pictureViewer.BorderStyle = BorderStyle.Fixed3D;
            pictureViewer.Dock = DockStyle.Fill;
            pictureViewer.Location = new Point(0, 0);
            pictureViewer.Name = "pictureViewer";
            pictureViewer.Size = new Size(556, 394);
            pictureViewer.SizeMode = PictureBoxSizeMode.Zoom;
            pictureViewer.TabIndex = 0;
            pictureViewer.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(groupNav);
            panel3.Controls.Add(groupZoom);
            panel3.Controls.Add(labelNewName);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(labelCurrentName);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(12, 427);
            panel3.Name = "panel3";
            panel3.Size = new Size(810, 102);
            panel3.TabIndex = 10;
            // 
            // groupNav
            // 
            groupNav.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupNav.Controls.Add(btnPicturePrevious);
            groupNav.Controls.Add(btnPictureNext);
            groupNav.Location = new Point(667, 7);
            groupNav.Name = "groupNav";
            groupNav.Size = new Size(102, 55);
            groupNav.TabIndex = 6;
            groupNav.TabStop = false;
            groupNav.Text = "Navigation";
            // 
            // btnPicturePrevious
            // 
            btnPicturePrevious.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPicturePrevious.FlatStyle = FlatStyle.Flat;
            btnPicturePrevious.Location = new Point(19, 22);
            btnPicturePrevious.Name = "btnPicturePrevious";
            btnPicturePrevious.Size = new Size(22, 23);
            btnPicturePrevious.TabIndex = 0;
            btnPicturePrevious.Text = "<";
            btnPicturePrevious.UseVisualStyleBackColor = true;
            btnPicturePrevious.Click += btnPicturePrevious_Click;
            // 
            // btnPictureNext
            // 
            btnPictureNext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPictureNext.FlatStyle = FlatStyle.Flat;
            btnPictureNext.Location = new Point(63, 22);
            btnPictureNext.Name = "btnPictureNext";
            btnPictureNext.Size = new Size(22, 23);
            btnPictureNext.TabIndex = 1;
            btnPictureNext.Text = ">";
            btnPictureNext.UseVisualStyleBackColor = true;
            btnPictureNext.Click += btnPictureNext_Click;
            // 
            // groupZoom
            // 
            groupZoom.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupZoom.Controls.Add(btnPictureZoomOut);
            groupZoom.Controls.Add(btnPictureZoomReset);
            groupZoom.Controls.Add(btnPictureZoomIn);
            groupZoom.Location = new Point(524, 7);
            groupZoom.Name = "groupZoom";
            groupZoom.Size = new Size(103, 55);
            groupZoom.TabIndex = 5;
            groupZoom.TabStop = false;
            groupZoom.Text = "Zoom";
            // 
            // btnPictureZoomOut
            // 
            btnPictureZoomOut.FlatStyle = FlatStyle.Flat;
            btnPictureZoomOut.Location = new Point(10, 22);
            btnPictureZoomOut.Name = "btnPictureZoomOut";
            btnPictureZoomOut.Size = new Size(23, 23);
            btnPictureZoomOut.TabIndex = 2;
            btnPictureZoomOut.Text = "-";
            btnPictureZoomOut.UseVisualStyleBackColor = true;
            btnPictureZoomOut.Click += btnPictureZoomOut_Click;
            // 
            // btnPictureZoomReset
            // 
            btnPictureZoomReset.FlatStyle = FlatStyle.Flat;
            btnPictureZoomReset.Location = new Point(39, 22);
            btnPictureZoomReset.Name = "btnPictureZoomReset";
            btnPictureZoomReset.Size = new Size(23, 23);
            btnPictureZoomReset.TabIndex = 4;
            btnPictureZoomReset.Text = "1";
            btnPictureZoomReset.UseVisualStyleBackColor = true;
            btnPictureZoomReset.Click += btnPictureZoomReset_Click;
            // 
            // btnPictureZoomIn
            // 
            btnPictureZoomIn.FlatStyle = FlatStyle.Flat;
            btnPictureZoomIn.Location = new Point(68, 22);
            btnPictureZoomIn.Name = "btnPictureZoomIn";
            btnPictureZoomIn.Size = new Size(23, 23);
            btnPictureZoomIn.TabIndex = 3;
            btnPictureZoomIn.Text = "+";
            btnPictureZoomIn.UseVisualStyleBackColor = true;
            btnPictureZoomIn.Click += btnPictureZoomIn_Click;
            // 
            // labelNewName
            // 
            labelNewName.AutoSize = true;
            labelNewName.Location = new Point(12, 71);
            labelNewName.Name = "labelNewName";
            labelNewName.Size = new Size(12, 15);
            labelNewName.TabIndex = 10;
            labelNewName.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 56);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 9;
            label6.Text = "New name";
            // 
            // labelCurrentName
            // 
            labelCurrentName.AutoSize = true;
            labelCurrentName.Location = new Point(12, 26);
            labelCurrentName.Name = "labelCurrentName";
            labelCurrentName.Size = new Size(12, 15);
            labelCurrentName.TabIndex = 8;
            labelCurrentName.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 11);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 7;
            label4.Text = "Current name";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(834, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openPictureToolStripMenuItem, openFolderToolStripMenuItem, printToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openPictureToolStripMenuItem
            // 
            openPictureToolStripMenuItem.Name = "openPictureToolStripMenuItem";
            openPictureToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openPictureToolStripMenuItem.Size = new Size(205, 22);
            openPictureToolStripMenuItem.Text = "Open Picture";
            openPictureToolStripMenuItem.Click += openPictureToolStripMenuItem_Click;
            // 
            // openFolderToolStripMenuItem
            // 
            openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            openFolderToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.O;
            openFolderToolStripMenuItem.Size = new Size(205, 22);
            openFolderToolStripMenuItem.Text = "Open Folder";
            openFolderToolStripMenuItem.Click += openFolderToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(205, 22);
            printToolStripMenuItem.Text = "Print";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            exitToolStripMenuItem.Size = new Size(205, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(155, 343);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 11;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 541);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(850, 580);
            Name = "MainForm";
            Text = "Danbooru Name Tagger";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureViewer).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupNav.ResumeLayout(false);
            groupZoom.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tagSearch;
        private Label label1;
        private Label label2;
        private TextBox composedName;
        private Label label3;
        private ListBoxEx tagList;
        private CheckBox nameSpacesCheck;
        private Button btnComposedNameCopy;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureViewer;
        private Panel panel3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openPictureToolStripMenuItem;
        private ToolStripMenuItem openFolderToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button btnPictureNext;
        private Button btnPicturePrevious;
        private Button btnPictureZoomReset;
        private Button btnPictureZoomIn;
        private Button btnPictureZoomOut;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private GroupBox groupNav;
        private GroupBox groupZoom;
        private Label label6;
        private Label labelCurrentName;
        private Label label4;
        private Label labelNewName;
        private Button btnRename;
        private Button btnReset;
    }
}
