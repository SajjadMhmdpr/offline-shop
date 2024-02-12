using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bussiness_entity;
using System.Data.Entity;

namespace data_acsess
{
    public class dl_customer
    {
        public void create(customer c)
        {
            DB db = new DB();
            db.customers.Add(c);
            db.SaveChanges();
        }
        /// <summary>
        /// ثبت نام
        /// </summary>
        /// <param name="c"></param>
        /// <param name="azghabl"></param>
        /// <returns></returns>
        public bool search(customer c , ref bool azghabl)
        {
            DB db = new DB();
            bool f2 = false;
            foreach (var item in db.customers)
            {
                if ((c.name == item.name && c.family == item.family && c.telephone == item.telephone) ||
                   (c.name == item.name && c.family == item.family && c.username == item.username && c.password == item.password))
                {
                    if (item.status == false)
                    {
                        item.status = true;
                        azghabl = true;
                    }
                        
                    f2 = true;
                }
            }
            db.SaveChanges();
            return f2;
        }
        /// <summary>
        /// ورود
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool search(customer c)
        {
            DB db = new DB();
            bool f2 = false;

            foreach (var item in db.customers)
            {
                if ( c.username == item.username && c.password == item.password)
                {
                    f2 = true;
                }
            }

            return f2;
        }
    }
}
