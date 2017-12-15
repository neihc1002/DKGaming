using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class ContentConfig
    {
        DKGamingDBContext db = new DKGamingDBContext();
        public string GetContent(string config)
        {
            var cf = db.ContentConfig.Find(config);
            if (cf != null)
            {
                return cf.Content;
            }
            return "";
        }
    }
}
