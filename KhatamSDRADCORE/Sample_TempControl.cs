using System.Web.UI;

namespace MyProject.templates.units
{
    [ParseChildren(true)]
    public partial class Box : System.Web.UI.UserControl
    {
        private ITemplate contents = null;

        [TemplateContainer(typeof(TemplateControl))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateInstance(TemplateInstance.Single)]
        public ITemplate Contents
        {
            get
            {
                return contents;
            }
            set
            {
                contents = value;
            }
        }

        void Page_Init()
        {
            this.Controls.Add(new LiteralControl("sssssss"));
            if (contents != null)
                contents.InstantiateIn(this);
            this.Controls.Add(new LiteralControl("bbbbbbb"));
        }
    }
}