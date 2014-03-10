using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace CraigslistCrawlerNotifier
{
    public partial class MainForm : Form
    {
        List<string> ParagraphTagList;

        public MainForm()
        {
            InitializeComponent();

            this.ParagraphTagList = new List<string>();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string SearchQuery = txtBx_SearchString.Text.Trim().Replace(" ", "+");

            string UrlQuery = string.Concat("http://boston.craigslist.org/search/?sort=date&catAbb=sss&query=", SearchQuery);

            WebRequest Request = WebRequest.Create(UrlQuery);
            WebResponse Response = Request.GetResponse();
            Stream PageData = Response.GetResponseStream();
            string PageHtml = string.Empty;
            using (StreamReader sr = new StreamReader(PageData))
            {
                PageHtml = sr.ReadToEnd();
            }

            // Match paragraph contents
            Match Content = Regex.Match(PageHtml, @"<p.*/p>", RegexOptions.None);

            int start = Content.Value.IndexOf("<p");
            int end = Content.Value.IndexOf("/p>");

            string FullPage = Content.Value;

            string SubSet = String.Empty;

            while (start > -1 && end > -1)
            {
                SubSet = FullPage.Substring(start, end + 3).Trim();
                FullPage = FullPage.Substring(end + 3).Trim();

                if (!string.IsNullOrEmpty(SubSet))
                {
                    this.ParagraphTagList.Add(SubSet);
                }

                start = FullPage.IndexOf("<p");
                end = FullPage.IndexOf("/p>");
            }

            foreach (string item in this.ParagraphTagList)
            {
                this.ProcessParagraphItem(item);
            }
        }

        private void ProcessParagraphItem(string data)
        {
            //<span class="pl"> = Item
            //<span class="price"> = Price
            //<span class="date"> = Date
            //<span class="pnr"> = Location
            Match date = Regex.Match(data, "<span\\s+class\\s*=\\s*\"date\"\\s*>[a-zA-Z0-9\\s]+<\\s*/\\s*span\\s*>");
            Match price = Regex.Match(data, "<span\\s+class\\s*=\\s*\"\\s*price\\s*\"\\s*>&#x0024;[0-9\\.]*<\\s*/\\s*span\\s*>");
        }
    }
}
