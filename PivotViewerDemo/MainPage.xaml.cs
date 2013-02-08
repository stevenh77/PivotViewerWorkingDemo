namespace PivotViewerDemo
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.pivotViewer.ItemsSource = Factory.GetData();
        }
    }
}
