using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCP_Enterprise.Class
{
    public class KitList
    {
        public static DataTable GetMoh(string mo_number)
        {
            DataTable dt = DataSupport.RunDataTableDapper($@"SELECT [mohId]
	                  ,(Select ecoNum from MIBOMH where bomitem = m.buildItem and bomrev = m.bomrev)[pcn number]
                      ,(Select descr from MIItem where itemid = m.buildItem)[descr]
                      ,[locId]
                      ,[buildItem]
                      ,[bomItem] 
                      ,[bomRev]
                      ,[ordQty]
                      ,[ordDate]
                      ,[startDate]
                      ,[endDate]
                      ,[rowVer]
                  FROM [MIMOH] m
                  where mohId = '{mo_number}'");
            return dt;
        }
        public static DataTable GetMoDetails(string mo_number)
        {
            DataTable dt = DataSupport.RunDataTableDapper($@"Select mohId
                      ,lineNbr
                      ,[type]
                      ,partId
                      ,item.descr [Description]
                      ,item.type
                      ,(Select mfgName from [MIQMFG] mfg where mfg.mfgId = item.mfgid and mfg.itemId = momd.partId)[mfg]
                      ,(Select mfgProdCode from [MIQMFG] mfg where mfg.mfgId = item.mfgid and mfg.itemId = momd.partId)[mfg product code]
                      ,srcLoc
                      ,'' as [stock]
                      ,qty [unit qty]
                      ,reqQty [mo qty]
                      ,wipQty [Wip qty]
                      ,relQty [pick qty]
                      ,'' [short qty]
                      ,'' [unit]
                      FROM [MIMOMD] momd
                      join MIITEM item on item.itemId = momd.partId
                      where mohId = '{mo_number}'");
            return dt;
        }
    }
}
