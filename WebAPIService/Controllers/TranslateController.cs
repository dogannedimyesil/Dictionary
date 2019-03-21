using BLL;
using Entity;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIService.Controllers
{
    public class TranslateController : ApiController
    {
        UnitOfWork _uw = new UnitOfWork();
        public List<string> Translate(int FromLangId, int ToLangId, string word)
        {
            HomeViewModel hvm = new HomeViewModel();
            hvm.FromLang = FromLangId;
            hvm.ToLang = ToLangId;
            hvm.FromWord = word;

            var sonuc = _uw.TranslateManager.Translate(hvm);
            return sonuc;
        }
    }
}
