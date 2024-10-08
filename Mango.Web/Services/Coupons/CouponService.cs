﻿using Mango.Web.DTOS;
using Mango.Web.DTOS.Coupons;
using Mango.Web.Interfaces.Services;
using Mango.Web.Interfaces.Services.Coupons;
using Mango.Web.Utility;
using Microsoft.AspNetCore.Server.Kestrel.Core.Features;

namespace Mango.Web.Services.Coupons
{
    public class CouponService(IBaseService baseService) : ICouponService
    {
        public Task<ResponseDto?> CreateCouponsAsync(CouponDto couponDto)
        {
            return baseService.SendAsync(new RequestDto
            {
                ApiType = SD.ApiType.POST,
                Data = couponDto,
                Url = SD.CouponAPIBase + "/api/Coupons"
            });
        }

        public Task<ResponseDto?> DeleteCouponsAsync(int id)
        {
            return baseService.SendAsync(new RequestDto
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/Coupons/" + id
            });
        }

        public Task<ResponseDto?> GetAllCouponsAsync()
        {
            return baseService.SendAsync(new RequestDto
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/Coupons"
            });
        }

        public Task<ResponseDto?> GetCouponByIdAsync(int id)
        {
            return baseService.SendAsync(new RequestDto
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/Coupons/" + id
            });
        }

        public Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponDto)
        {
            return baseService.SendAsync(new RequestDto
            {
                ApiType = SD.ApiType.PUT,
                Data = couponDto,
                Url = SD.CouponAPIBase + "/api/Coupons"
            });
        }
    }
}
