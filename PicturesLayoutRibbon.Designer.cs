namespace QuickLayout
{
    partial class PicturesLayoutRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public PicturesLayoutRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.QuickLayoutTab = this.Factory.CreateRibbonTab();
            this.PicturesLayouter = this.Factory.CreateRibbonGroup();
            this.RestorePicturesSizeButton = this.Factory.CreateRibbonButton();
            this.QuickLayoutTab.SuspendLayout();
            this.PicturesLayouter.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuickLayoutTab
            // 
            this.QuickLayoutTab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.QuickLayoutTab.Groups.Add(this.PicturesLayouter);
            this.QuickLayoutTab.Label = "快速排版";
            this.QuickLayoutTab.Name = "QuickLayoutTab";
            // 
            // PicturesLayouter
            // 
            this.PicturesLayouter.Items.Add(this.RestorePicturesSizeButton);
            this.PicturesLayouter.Label = "图片";
            this.PicturesLayouter.Name = "PicturesLayouter";
            // 
            // RestorePicturesSizeButton
            // 
            this.RestorePicturesSizeButton.Label = "重置图像大小";
            this.RestorePicturesSizeButton.Name = "RestorePicturesSizeButton";
            this.RestorePicturesSizeButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.RestorePicturesSizeButton_Click);
            // 
            // PicturesLayoutRibbon
            // 
            this.Name = "PicturesLayoutRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.QuickLayoutTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.PicturesLayoutRibbonInstance_Load);
            this.QuickLayoutTab.ResumeLayout(false);
            this.QuickLayoutTab.PerformLayout();
            this.PicturesLayouter.ResumeLayout(false);
            this.PicturesLayouter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab QuickLayoutTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup PicturesLayouter;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton RestorePicturesSizeButton;
    }

    partial class ThisRibbonCollection
    {
        internal PicturesLayoutRibbon PicturesLayoutRibbonInstance
        {
            get { return this.GetRibbon<PicturesLayoutRibbon>(); }
        }
    }
}
