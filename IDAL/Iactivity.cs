using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data;
using System.Data.SqlClient;

namespace IDAL
{
   public  interface Iactivity
   {
        int InsertActivity(activity activity);
        DataTable SelectTodayActivity(string act_name );
        SqlDataReader Selectusers(string user_name);
        DataTable SelectActivity(int ActId);
        DataTable SelectAll();
        DataTable SelectDate();
        int UpdateLike(int ActId);
        int UpdateDislike(int ActId);

   }
}
