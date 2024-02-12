using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bussiness_entity;
using data_acsess;

namespace bussiness_logic
{
    public class bl_customer
    {
        public void create(customer c)
        {
            dl_customer dlcs = new dl_customer();
            dlcs.create(c);
        }
        /// <summary>
        /// برای ثبت نام
        /// </summary>
        /// <param name="c"></param>
        /// <param name="azghabl"></param>
        /// <returns></returns>
        public bool search(customer c , ref bool azghabl)
        {
            dl_customer dlcs = new dl_customer();
            return dlcs.search(c , ref azghabl);

        }
        /// <summary>
        /// ورود
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool search(customer c)
        {
            dl_customer dlcus = new dl_customer();
            return dlcus.search(c);
        }
    }
}
