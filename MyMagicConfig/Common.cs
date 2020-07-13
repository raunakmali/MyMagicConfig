using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace MyMagicConfig
{
    public class Common
    {
        public static string toHTML_Table(DataTable dt)
        {
            if (dt.Rows.Count == 0) return ""; // enter code here

            StringBuilder builder = new StringBuilder();
            //builder.Append("<html>");
            //builder.Append("<head>");
            //builder.Append("<title>");
            //builder.Append("Page-");
            //builder.Append(Guid.NewGuid());
            //builder.Append("</title>");
            //builder.Append("</head>");
            //builder.Append("<body>");
            builder.Append("<table  ");
            builder.Append("class=\"table table-striped table-hover table-bordered\">");
            builder.Append(" <thead>");
            builder.Append("<tr>");
            foreach (DataColumn c in dt.Columns)
            {
                builder.Append("<th ><b>");
                builder.Append(c.ColumnName);
                builder.Append("</b><i class=\"fa fa-sort\"></i></th>");
            }
            builder.Append("<th>Actions</th>");
            builder.Append("</tr>");
            builder.Append(" </thead>");
            builder.Append(" <tbody>");
            foreach (DataRow r in dt.Rows)
            {
                builder.Append("<tr>");
                foreach (DataColumn c in dt.Columns)
                {
                    builder.Append("<td>");
                    builder.Append(r[c.ColumnName]);
                    builder.Append("</td>");
                }
                builder.Append("<td>");
                builder.Append("<a href = \"#\" class=\"view\" title=\"View\" data-toggle=\"tooltip\"><i class=\"material-icons\">&#xE417;</i></a>");
                builder.Append("<a href = \"#\" class=\"edit\" title=\"Edit\" data-toggle=\"tooltip\"><i class=\"material-icons\">&#xE254;</i></a>");
                builder.Append("<a href = \"#\" class=\"delete\" title=\"Delete\" data-toggle=\"tooltip\"><i class=\"material-icons\">&#xE872;</i></a>");

                builder.Append("</td>");
                builder.Append("</tr>");
            }
            builder.Append(" </tbody>");
            builder.Append("</table>");
            //builder.Append("</body>");
            //builder.Append("</html>");

            return builder.ToString();
        }
    }
}