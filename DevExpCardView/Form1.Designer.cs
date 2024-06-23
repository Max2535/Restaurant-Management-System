namespace DevExpCardView
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.xImageURL = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.xDescription = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.xProductName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.grdTestEx = new DevExpress.XtraGrid.GridControl();
            this.productCard = new DevExpress.XtraGrid.Views.Card.CardView();
            this.ImageURL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productPictureEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.ProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Weight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.label1 = new System.Windows.Forms.Label();
            this.chkRTL = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdTestEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xImageURL
            // 
            resources.ApplyResources(this.xImageURL, "xImageURL");
            this.xImageURL.FieldName = "ImageURL";
            this.xImageURL.Name = "xImageURL";
            // 
            // xDescription
            // 
            resources.ApplyResources(this.xDescription, "xDescription");
            this.xDescription.FieldName = "Description";
            this.xDescription.Name = "xDescription";
            // 
            // xProductName
            // 
            resources.ApplyResources(this.xProductName, "xProductName");
            this.xProductName.FieldName = "ProductName";
            this.xProductName.Name = "xProductName";
            // 
            // grdTestEx
            // 
            resources.ApplyResources(this.grdTestEx, "grdTestEx");
            this.grdTestEx.MainView = this.productCard;
            this.grdTestEx.Name = "grdTestEx";
            this.grdTestEx.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.productPictureEdit});
            this.grdTestEx.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.productCard,
            this.tileView1});
            // 
            // productCard
            // 
            this.productCard.Appearance.EmptySpace.BackColor = System.Drawing.Color.MintCream;
            this.productCard.Appearance.EmptySpace.Options.UseBackColor = true;
            this.productCard.Appearance.FocusedCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productCard.Appearance.FocusedCardCaption.ForeColor = System.Drawing.Color.Maroon;
            this.productCard.Appearance.FocusedCardCaption.Options.UseBackColor = true;
            this.productCard.Appearance.FocusedCardCaption.Options.UseForeColor = true;
            this.productCard.CardWidth = 300;
            this.productCard.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ImageURL,
            this.ProductID,
            this.ProductName,
            this.Description,
            this.Price,
            this.Weight});
            this.productCard.DetailHeight = 100;
            this.productCard.GridControl = this.grdTestEx;
            this.productCard.Name = "productCard";
            this.productCard.OptionsBehavior.Editable = false;
            this.productCard.OptionsBehavior.FieldAutoHeight = true;
            this.productCard.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.productCard.CustomDrawCardCaption += new DevExpress.XtraGrid.Views.Card.CardCaptionCustomDrawEventHandler(this.productCard_CustomDrawCardCaption);
            // 
            // ImageURL
            // 
            resources.ApplyResources(this.ImageURL, "ImageURL");
            this.ImageURL.ColumnEdit = this.productPictureEdit;
            this.ImageURL.FieldName = "ImageURL";
            this.ImageURL.MinWidth = 10;
            this.ImageURL.Name = "ImageURL";
            this.ImageURL.OptionsColumn.FixedWidth = true;
            // 
            // productPictureEdit
            // 
            this.productPictureEdit.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("productPictureEdit.Appearance.Font")));
            this.productPictureEdit.Appearance.Options.UseFont = true;
            this.productPictureEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.productPictureEdit.Caption.Text = "Product Photo";
            this.productPictureEdit.CustomHeight = 200;
            this.productPictureEdit.Name = "productPictureEdit";
            this.productPictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // ProductID
            // 
            resources.ApplyResources(this.ProductID, "ProductID");
            this.ProductID.FieldName = "ProductID";
            this.ProductID.Name = "ProductID";
            // 
            // ProductName
            // 
            resources.ApplyResources(this.ProductName, "ProductName");
            this.ProductName.FieldName = "ProductName";
            this.ProductName.Name = "ProductName";
            // 
            // Description
            // 
            resources.ApplyResources(this.Description, "Description");
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            // 
            // Price
            // 
            resources.ApplyResources(this.Price, "Price");
            this.Price.FieldName = "Price";
            this.Price.Name = "Price";
            // 
            // Weight
            // 
            resources.ApplyResources(this.Weight, "Weight");
            this.Weight.FieldName = "Weight";
            this.Weight.Name = "Weight";
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.xImageURL,
            this.xDescription,
            this.xProductName});
            this.tileView1.GridControl = this.grdTestEx;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsEditForm.EditFormColumnCount = 0;
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(360, 180);
            this.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView1.OptionsTiles.RowCount = 0;
            tileViewItemElement2.Column = this.xImageURL;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.ImageOptions.ImageSize = new System.Drawing.Size(200, 180);
            resources.ApplyResources(tileViewItemElement2, "tileViewItemElement2");
            this.tileView1.TileTemplate.Add(tileViewItemElement2);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Name = "label1";
            // 
            // chkRTL
            // 
            resources.ApplyResources(this.chkRTL, "chkRTL");
            this.chkRTL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkRTL.Name = "chkRTL";
            this.chkRTL.UseVisualStyleBackColor = true;
            this.chkRTL.CheckedChanged += new System.EventHandler(this.chkRTL_CheckedChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkRTL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdTestEx);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTestEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdTestEx;
        private DevExpress.XtraGrid.Views.Card.CardView productCard;
        private DevExpress.XtraGrid.Columns.GridColumn ImageURL;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit productPictureEdit;
        private DevExpress.XtraGrid.Columns.GridColumn ProductID;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn Weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkRTL;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn xImageURL;
        private DevExpress.XtraGrid.Columns.TileViewColumn xDescription;
        private DevExpress.XtraGrid.Columns.TileViewColumn xProductName;
    }
}

