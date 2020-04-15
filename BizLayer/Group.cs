using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ConfigLayer;
using DbLayer;

namespace AccountLayer
{
   public class Group
   {
       static Group()
       {

       }

       public static void AddGroup(string acode, string adesc,string type,decimal curbal)
       {
           SPAccess sp = new SPAccess(DbConfig.GetConStr("MAINDB"));
           sp.Add("@A_CODE", typeof(System.String), acode);
           sp.Add("@A_DESC", typeof(System.String), adesc);
           sp.Add("@A_TYPE", typeof(System.String), type);
           sp.Add("@A_CURRB", typeof(System.Decimal), curbal);

           sp.ExecuteNonQuery("spCreateFAGroup");
       }

       public static DataTable GetGroup(string acode)
       {
           SPAccess sp = new SPAccess(DbConfig.GetConStr("MAINDB"));
           sp.Add("@A_CODE", typeof(System.String), acode);
           
           DataSet ds = sp.Execute("spGetFAGroup");
           return ds.Tables[0];
       
       }

       public static void DeleteGroup(string acode)
       {
           SPAccess sp = new SPAccess(DbConfig.GetConStr("MAINDB"));
           sp.Add("@A_CODE", typeof(System.String), acode);

            sp.ExecuteNonQuery("spDeleteFAGroup");
              
       }

       public static bool Isexist(string acode)
       {
           DataTable dt = GetGroup(acode);
           return dt.Rows.Count > 0;
          
       }

       public static DataTable ListGroup()
       {
           SPAccess sp = new SPAccess(DbConfig.GetConStr("MAINDB"));
           DataSet ds = sp.Execute("spListFAGroup");
           return ds.Tables[0];
       }

       public static void UpdateGroup(string acode, string adesc, string type, decimal curbal)
       {
           SPAccess sp = new SPAccess(DbConfig.GetConStr("MAINDB"));
           sp.Add("@A_CODE", typeof(System.String), acode);
           sp.Add("@A_DESC", typeof(System.String), adesc);
           sp.Add("@A_TYPE", typeof(System.String), type);
           sp.Add("@A_CURRB", typeof(System.Decimal), curbal);

           sp.ExecuteNonQuery("spUpdateFAGroup");
       }

    }
}
