using BTCP_Enterprise.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Utility.ModifyRegistry;
using System.Windows.Forms;

namespace BTCP_Enterprise
{
    public static class Connection
    {
        public static DataSupport GetBroadbandConnection
        {
            get
            {
                return new DataSupport(GetConnectionstring("BTC_ENTERPRISE"));
            }
        }

        //public static DataSupport GetWMSConnection
        //{
        //    get
        //    {
        //        return new DataSupport(GetConnectionstring("WMS"));
        //    }
        //}

        //public static string GetWMSConnectionString { get; } = GetConnectionstring("WMS");

        public static string GetConnectionStringReg
        {
            get
            {
                return  GetConnectionstring("BTC_ENTERPRISE");
            }
        }
        public static string GetConnectionstring(string connName)
        {
            if (Utils.DBConnection == null)
            {
                Utils.SetConnectionDetails();
            }
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            Utils.DBConnection.TryGetValue(connName, out Dictionary<string, string> conn);
            if (conn != null)
            {
                builder.InitialCatalog = conn["DBNAME"];
                builder.DataSource = conn["SERVER"];
                builder.UserID = conn["USERNAME"];
                builder.Password = conn["PASSWORD"];
            }
            return builder.ConnectionString;
        }
        public static void InitializeConnection()
        {
            RegistrySupport registry = new RegistrySupport();
            String data = registry.Read(Def.REGKEY_SUB);
            if (data == null)
            {
                data += String.Format($"BTC_ENTERPRISE<limiter>192.168.20.15<limiter>sa<limiter>MISys_SBM1<limiter>BROADBAND<limiter1>");
                registry.Write(Def.REGKEY_SUB, data);
            }
            String[] programs = data.Split(new String[] { "<limiter1>" }, StringSplitOptions.RemoveEmptyEntries);

            Utils.SetConnectionDetails();
            var stat =  Class.SqlCon.connections(BTCP_Enterprise.Connection.GetConnectionStringReg);
            //Class.MRPClass.dbname = Utils.DBConnection["BTC_ENTERPRISE"]["DBNAME"].ToString() + " and " + Utils.DBConnection["PTA"]["DBNAME"].ToString();
            //this.Text = $"Login v{Assembly.GetExecutingAssembly().GetName().Version.ToString()} - {Class.MRPClass.dbname}";
            //if (stat.State == ConnectionState.Open)
            //{
            //    label3.Text = $"Status : Connected ";
            //    stat.Close();
            //}
            //else
            //{
            //    label3.Text = $"Status : Disconnected ";
            //}
            //dbConnectionSettings = Utils.DBConnection;
        }
    }
}