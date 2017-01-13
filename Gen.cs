using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MetaGen
{
    public class Gen
    {
        private string ctags;
        private string auth;
        private string desc;
        private string keyw;
        private string Titl;
        private string ogTitle;
        private string ogImage;
        private string ogDescription;
        private string ogUrl;
        private RobotsType rbts;


        public enum RobotsType
        { NOINDEX, NOFOLLOW, NOARCHIVE, NOSNIPPET, NOODP, NONE, INDEXFOLLOW, NOINDEXFOLLOW, NOINDEXNOFOLLOW, NOUSE }

        /// <summary>
        ///    Author of the Page. You can use a Name or a domain to identify this.
        /// </summary>
        public string Author
        {   set { auth = value; } get { return auth; } }

        /// <summary>
        ///    Author of the Page. You can use a Name or a domain to identify this.
        /// </summary>
        public string Title
        { set { Titl = value; } get { return Titl; } }

        /// <summary>
        ///    Description of the website or the page you are loading.
        /// </summary>
        public string Description
        { set { desc = value; } get { return desc; } }

        /// <summary>
        ///    Comma separated values for search engine indexation.
        /// </summary>
        public string Keywords
        { set { keyw = value; } get { return keyw; } }

        /// <summary>
        ///    Value that represent the behavior of search engines when they get your page.
        ///    Possible values are: NOINDEX,NOFOLLOW,NOARCHIVE,NOSNIPPET,NOODP,NONE
        /// </summary>
        public RobotsType Robots
        { set { rbts = value; } get { return rbts; } }

        ///// <summary>
        /////     Facebook Tag Title
        ///// </summary>
        //public string FBTitle
        //{ set { ogTitle = value; } get { return ogTitle; } }

        ///// <summary>
        /////     Facebook Tag Image
        ///// </summary>
        //public string FBImage
        //{ set { ogImage = value; } get { return ogImage; } }

        ///// <summary>
        /////     Facebook Tag Description
        ///// </summary>
        //public string FBDescription
        //{ set { ogDescription = value; } get { return ogDescription; } }

        ///// <summary>
        /////     Facebook Tag Url
        ///// </summary>
        //public string FBUrl
        //{ set { ogUrl = value; } get { return ogUrl; } }
        
        /// <summary>
        ///    All values are asigned to blank and Robots to NONE.
        /// </summary>
        public Gen()
        {
            ctags = "";
            Author = "";
            Description = "";
            Keywords = "";
            Titl = "";
            Robots = RobotsType.INDEXFOLLOW;
        }

        /// <summary>
        ///    All values are asigned to blank and Robots to NONE except Author.
        /// </summary>
        /// <param name="vAuthor">Author of the Page. You can use a Name or a domain to identify this.</param>
        public Gen(string vAuthor)
        {
            ctags = "";
            Author = vAuthor;
            Description = "";
            Keywords = "";
            Titl = "";
            Robots = RobotsType.INDEXFOLLOW;
        }

        /// <summary>
        ///    All values are asigned to blank and Robots to NONE except Author and Description.
        /// </summary>
        /// <param name="vAuthor">Author of the Page. You can use a Name or a domain to identify this.</param>
        /// <param name="vDescription">Description of the website or the page you are loading.</param>
        public Gen(string vAuthor, string vDescription)
        {
            ctags = "";
            Author = vAuthor;
            Description = vDescription;
            Keywords = "";
            Titl = "";
            Robots = RobotsType.INDEXFOLLOW;
        }

        /// <summary>
        ///    It is assumed that Robots value is NONE.
        /// </summary>
        /// <param name="vAuthor">Author of the Page. You can use a Name or a domain to identify this.</param>
        /// <param name="vDescription">Description of the website or the page you are loading.</param>
        /// <param name="vKeywords">Comma separated values for search engine indexation.</param>
        public Gen(string vAuthor, string vDescription, string vKeywords)
        {
            ctags = "";
            Author = vAuthor;
            Description = vDescription;
            Keywords = vKeywords;
            Titl = "";
            Robots = RobotsType.INDEXFOLLOW;
        }

        /// <summary>
        ///    Submit the values for meta tag to be created.
        /// </summary>
        /// <param name="vAuthor">Author of the Page. You can use a Name or a domain to identify this.</param>
        /// <param name="vDescription">Description of the website or the page you are loading.</param>
        /// <param name="vKeywords">Comma separated values for search engine indexation.</param>
        /// <param name="vRobots">
        ///    Value that represent the behavior of search engines when they get your page.
        ///    You can use enum RobotsType to select available values.
        ///    Possible values are: NOINDEX,NOFOLLOW,NOARCHIVE,NOSNIPPET,NOODP,NONE
        /// </param>
        public Gen(string vAuthor, string vDescription, string vKeywords,string vTitle)
        {
            ctags = "";
            Author = vAuthor;
            Description = vDescription;
            Keywords = vKeywords;
            Title = vTitle;
            Robots = RobotsType.INDEXFOLLOW;
        }

        /// <summary>
        ///    Submit the values for meta tag to be created.
        /// </summary>
        /// <param name="vAuthor">Author of the Page. You can use a Name or a domain to identify this.</param>
        /// <param name="vDescription">Description of the website or the page you are loading.</param>
        /// <param name="vKeywords">Comma separated values for search engine indexation.</param>
        /// <param name="vRobots">
        ///    Value that represent the behavior of search engines when they get your page.
        ///    You can use enum RobotsType to select available values.
        ///    Possible values are: NOINDEX,NOFOLLOW,NOARCHIVE,NOSNIPPET,NOODP,NONE
        /// </param>
        public Gen(string vAuthor, string vDescription, string vKeywords, string vTitle, RobotsType vRobots)
        {
            ctags = "";
            Author = vAuthor;
            Description = vDescription;
            Keywords = vKeywords;
            Title = vTitle;
            Robots = vRobots;
        }

        /// <summary>
        /// Add custom meta tags
        /// </summary>
        /// <param name="name">Name of the tag</param>
        /// <param name="value">Value of the tag</param>
        public void AddCustomMeta(string name, string value)
        {
            if (ctags == "")
            {
                ctags = name + "," + value;
            }
            else
            {
                ctags += "|" + name + "," + value;
            }
        }

        /// <summary>
        /// Add custom tags for facebook
        /// </summary>
        /// <param name="fbTitle">Value of the Name</param>
        /// <param name="fbImage">Url of the Image</param>
        /// <param name="fbDescription">Value of the Description</param>
        /// <param name="fbUrl">Value of the Url</param>

        public void AddFacebookMeta(string fbTitle, string fbImage, string fbDescription, string fbUrl)
        {
            ogTitle = fbTitle;
            ogImage = fbImage;
            ogDescription = fbDescription;
            ogUrl = fbUrl;
        }

        /// <summary>
        ///     Add meta tag to the current page.
        /// </summary>
        /// <param name="CurrentPage">The variable Page in the WebForm you are calling this function.</param>
        public void Generate(Page CurrentPage)
        {
            HtmlMeta obj;
            
            try
            {
                if (Author != "")
                {
                    obj = new HtmlMeta();
                    obj.Name = "author";
                    obj.Content = Author;
                    CurrentPage.Header.Controls.Add(obj);
                    obj.Dispose();
                }

                if (Description != "")
                {
                    obj = new HtmlMeta();
                    obj.Name = "description";
                    obj.Content = Description;
                    CurrentPage.Header.Controls.Add(obj);
                    obj.Dispose();
                }

                if (Keywords != "")
                {
                    obj = new HtmlMeta();
                    obj.Name = "keywords";
                    obj.Content = Keywords;
                    CurrentPage.Header.Controls.Add(obj);
                    obj.Dispose();
                }

                if (Title != "")
                {
                    CurrentPage.Header.Title = Title;
                }

                obj = new HtmlMeta();
                obj.Name = "robots";
                if(Robots == RobotsType.INDEXFOLLOW)
                    obj.Content = "index,follow";
                else if(Robots == RobotsType.NOINDEXFOLLOW)
                    obj.Content = "noindex,follow";
                else if (Robots == RobotsType.NOINDEXNOFOLLOW)
                    obj.Content = "noindex,nofollow";
                else
                    obj.Content = Robots.ToString();

               if (Robots != RobotsType.NOUSE)
                    CurrentPage.Header.Controls.Add(obj);

                obj.Dispose();

                if (ctags != "")
                {
                    obj = new HtmlMeta();
                    string[] param;
                    string[] tags = ctags.Split("|".ToCharArray());

                    for (int i = 0; i < tags.Length; i++)
                    {
                        param = tags[i].Split(",".ToCharArray());
                        obj = new HtmlMeta();
                        obj.Name = param[0].ToString();
                        obj.Content = param[1].ToString();
                        CurrentPage.Header.Controls.Add(obj);
                        obj.Dispose();
                    }
                }

                if (ogTitle != null && ogTitle != "")
                {
                    obj = new HtmlMeta();
                    obj.Attributes["property"] = "og:title";
                    obj.Content = ogTitle;
                    CurrentPage.Header.Controls.Add(obj);
                    obj.Dispose();
                }
                if (ogImage != null && ogImage != "")
                {
                    obj = new HtmlMeta();
                    obj.Attributes["property"] = "og:image";
                    obj.Content = ogImage;
                    CurrentPage.Header.Controls.Add(obj);
                    obj.Dispose();
                }
                if (ogDescription != null && ogDescription != "")
                {
                    obj = new HtmlMeta();
                    obj.Attributes["property"] = "og:description";
                    obj.Content = ogDescription;
                    CurrentPage.Header.Controls.Add(obj);
                    obj.Dispose();
                }
                if (ogUrl != null && ogUrl != "")
                {
                    obj = new HtmlMeta();
                    obj.Attributes["property"] = "og:url";
                    obj.Content = ogUrl;
                    CurrentPage.Header.Controls.Add(obj);
                    obj.Dispose();
                }
                
            }
            catch (Exception ex)
            {
                string msg = "There was a problem trying to add meta tag to the header of the page. Be sure that header contains property runat=\"server\".";
                throw new Exception(msg, ex.InnerException);
            }
        }

        public void GenerateOnControl(PlaceHolder CurrentControl)
        {
            HtmlMeta obj;

            try
            {
                if (Author != "")
                {
                    obj = new HtmlMeta();
                    obj.Name = "author";
                    obj.Content = Author;
                    CurrentControl.Controls.Add(obj);
                    obj.Dispose();
                }

                if (Description != "")
                {
                    obj = new HtmlMeta();
                    obj.Name = "description";
                    obj.Content = Description;
                    CurrentControl.Controls.Add(obj);
                    obj.Dispose();
                }

                if (Keywords != "")
                {
                    obj = new HtmlMeta();
                    obj.Name = "keywords";
                    obj.Content = Keywords;
                    CurrentControl.Controls.Add(obj);
                    obj.Dispose();
                }

                if (Title != "")
                {
                    CurrentControl.Controls.Add(new HtmlTitle { Text= Title });
                }

                obj = new HtmlMeta();
                obj.Name = "robots";
                if (Robots == RobotsType.INDEXFOLLOW)
                    obj.Content = "index,follow";
                else if (Robots == RobotsType.NOINDEXFOLLOW)
                    obj.Content = "noindex,follow";
                else if (Robots == RobotsType.NOINDEXNOFOLLOW)
                    obj.Content = "noindex,nofollow";
                else
                    obj.Content = Robots.ToString();

                if (Robots != RobotsType.NOUSE)
                    CurrentControl.Controls.Add(obj);

                obj.Dispose();

                if (ctags != "")
                {
                    obj = new HtmlMeta();
                    string[] param;
                    string[] tags = ctags.Split("|".ToCharArray());

                    for (int i = 0; i < tags.Length; i++)
                    {
                        param = tags[i].Split(",".ToCharArray());
                        obj = new HtmlMeta();
                        obj.Name = param[0].ToString();
                        obj.Content = param[1].ToString();
                        CurrentControl.Controls.Add(obj);
                        obj.Dispose();
                    }
                }

                if (ogTitle != null && ogTitle != "")
                {
                    obj = new HtmlMeta();
                    obj.Attributes["property"] = "og:title";
                    obj.Content = ogTitle;
                    CurrentControl.Controls.Add(obj);
                    obj.Dispose();
                }
                if (ogImage != null && ogImage != "")
                {
                    obj = new HtmlMeta();
                    obj.Attributes["property"] = "og:image";
                    obj.Content = ogImage;
                    CurrentControl.Controls.Add(obj);
                    obj.Dispose();
                }
                if (ogDescription != null && ogDescription != "")
                {
                    obj = new HtmlMeta();
                    obj.Attributes["property"] = "og:description";
                    obj.Content = ogDescription;
                    CurrentControl.Controls.Add(obj);
                    obj.Dispose();
                }
                if (ogUrl != null && ogUrl != "")
                {
                    obj = new HtmlMeta();
                    obj.Attributes["property"] = "og:url";
                    obj.Content = ogUrl;
                    CurrentControl.Controls.Add(obj);
                    obj.Dispose();
                }

            }
            catch (Exception ex)
            {
                string msg = "There was a problem trying to add meta tag to the header of the page. Be sure that header contains property runat=\"server\".";
                throw new Exception(msg, ex.InnerException);
            }
        }

        ~ Gen()
        {

        }
    }
}
