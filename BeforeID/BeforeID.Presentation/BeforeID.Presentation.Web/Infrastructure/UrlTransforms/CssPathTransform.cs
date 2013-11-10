using System.Web;
using System.Web.Optimization;

namespace BeforeID.Presentation.Web.Infrastructure.UrlTransforms
{
    public class CssPathTransform : IItemTransform
    {
        public string Process(string includedVirtualPath, string input)
        {
            return new CssRewriteUrlTransform().Process("~" + VirtualPathUtility.ToAbsolute(includedVirtualPath), input);
        }
    }
}