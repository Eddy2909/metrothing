using System;
using MarkdownSharp;
using MetroFramework.Forms;

namespace MetroThing.Forms
{
    public partial class ChangelogForm : MetroForm
    {
        public ChangelogForm(string markdown)
        {
            InitializeComponent();

            var template =
                "<html><head><style>*, body {{ font-family: Calibri, Arial, 'Helvetica Neue', Helvetica, sans-serif; }}</style></head><body>{0}</body></html>";

            var html = new Markdown().Transform(markdown);

            changelogBrowser.DocumentText = String.Format(template, html);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}