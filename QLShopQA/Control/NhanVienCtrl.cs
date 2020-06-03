using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLShopQA.Model;
using QLShopQA.Object;

namespace QLShopQA.Control
{
    class NhanVienCtrl
    {
        NhanVienMod nvMod = new NhanVienMod();
        public DataTable getData()
        {
            return nvMod.GetData();
        }

        public bool addData(NhanVienObj nvobj)
        {
            return nvMod.AddData(nvobj);
        }
        public bool updData(NhanVienObj nvobj)
        {
            return nvMod.UpdData(nvobj);
        }
        public bool delData(string ma)
        {
            return nvMod.DelData(ma);
        }
    }
}
