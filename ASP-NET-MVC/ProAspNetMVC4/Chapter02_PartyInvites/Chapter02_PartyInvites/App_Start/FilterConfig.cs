﻿using System.Web;
using System.Web.Mvc;

namespace Chapter02_PartyInvites
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}