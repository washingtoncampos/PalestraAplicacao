
using System;

namespace TDC.UI.Web.Models
{
    public abstract class Entidade
    {
        private string id;

        public string Id
        {
            get
            {
                if (!string.IsNullOrEmpty(id))
                    return id;
                id = Guid.NewGuid().ToString("N");
                return id;
            }
            set { id = value; }
        }
    }

}