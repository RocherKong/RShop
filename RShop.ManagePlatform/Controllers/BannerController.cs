using RShop.Infrastructure.Message;
using RShop.Infrastructure.Web;
using RShop.ManagePlatform.ViewModels;
using RShop.TradingCenter.DomainService;
using RShop.TradingCenter.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RShop.ManagePlatform.Controllers
{
    public class BannerController : AdminController
    {
        private static readonly BannerService service = new BannerService();


        // GET: Banner
        public ActionResult Index(string Position = "", int PageIndex = 1, int PageSize = 10)
        {
            Hashtable reqParams = new Hashtable();
            reqParams.Add("Position", Position);
            var list = service.GetVListByPage(reqParams, PageSize, PageIndex);

            var pageList = list.ToMvcPagedList2(PageIndex, PageSize);
            return View(pageList);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Add(BannerModel entity)
        {
            ResponseMessage resp = new ResponseMessage();
            string[] Images = entity.ImageList.Split(',');

            if (Images.Length <= 0)
            {
                resp.IsSuccess = false;
                resp.Message = "无图不Banner!";
                return Json(resp);
            }

            T_Banner banner = null;
            IList<T_Banner> BannerList = new List<T_Banner>();

            string[] ImageAndRedirect = null;
            for (int i = 0; i < Images.Length; i++)
            {
                banner = new T_Banner();
                banner.Title = entity.Title;
                banner.Position = entity.Position;
                banner.IsDelete = false;
                banner.Creator = Admin.Id;
                banner.CreateTime = DateTime.Now;
                ImageAndRedirect = Images[i].Split(';');
                banner.ImageUrl = ImageAndRedirect[0];
                banner.RedirectUrl = ImageAndRedirect[1];
                banner.SortId = i;
                BannerList.Add(banner);
            }
            service.InsertBatch(BannerList);
            return Json(resp);

        }


        public ActionResult Edit(string Position)
        {
            Hashtable reqParams = new Hashtable();
            reqParams.Add("Position", Position);
            IList<T_Banner> bannerlist = service.GetList(reqParams);
            return View(bannerlist);
        }

        [HttpPost]
        public JsonResult Edit(BannerModel entity)
        {
            ResponseMessage resp = new ResponseMessage();
            string[] Images = entity.ImageList.Split(',');

            if (Images.Length <= 0)
            {
                resp.IsSuccess = false;
                resp.Message = "无图不Banner!";
                return Json(resp);
            }

            T_Banner banner = null;
            IList<T_Banner> BannerList = new List<T_Banner>();

            string[] ImageAndRedirect = null;
            for (int i = 0; i < Images.Length; i++)
            {
                banner = new T_Banner();
                banner.Title = entity.Title;
                banner.Position = entity.Position;
                banner.IsDelete = false;
                banner.Creator = Admin.Id;
                banner.CreateTime = DateTime.Now;
                ImageAndRedirect = Images[i].Split(';');
                banner.ImageUrl = ImageAndRedirect[0];
                banner.RedirectUrl = ImageAndRedirect[1];
                banner.SortId = i;
                BannerList.Add(banner);
            }
            service.UpdateBatch(BannerList);
            return Json(resp);
        }

        public JsonResult Delete(string Position)
        {
            service.DeleteAll(Position);
            ResponseMessage resp = new ResponseMessage();
            return Json(resp);
        }
    }

   
}