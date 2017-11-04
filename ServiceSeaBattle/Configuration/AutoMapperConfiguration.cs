using Api.Model.Library.ApiModelSeaBattel;
using AutoMapper;
using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSeaBattle.Configuration
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                #region User
                cfg.CreateMap<User, UserModel>()
                .ForMember(um => um.Id, m => m.MapFrom(u => u.Id))
                .ForMember(um => um.UserAccountId, m => m.MapFrom(u => u.UserAccountId))
                .ForMember(um => um.FirstName, m => m.MapFrom(u => u.FirstName))
                .ForMember(um => um.LastName, m => m.MapFrom(u => u.LastName));
                cfg.CreateMap<UserModel, User>()
                .ForMember(u => u.Id, m => m.MapFrom(um => um.Id))
                .ForMember(u => u.UserAccountId, m => m.MapFrom(um => um.UserAccountId))
                .ForMember(u => u.FirstName, m => m.MapFrom(um => um.FirstName))
                .ForMember(u => u.LastName, m => m.MapFrom(um => um.LastName));
                #endregion
                #region UserAccount
                cfg.CreateMap<UserAccount, UserAccountModel>()
                .ForMember(am => am.Id, m => m.MapFrom(a => a.UserAccountId))
                .ForMember(am => am.Salt, m => m.MapFrom(a => a.Salt));
                cfg.CreateMap<UserAccountModel,UserAccount>()
                .ForMember(a => a.UserAccountId, m => m.MapFrom(am => am.Id))
                .ForMember(a => a.Salt, m => m.MapFrom(am => am.Salt));
                #endregion
                #region BattelField
                cfg.CreateMap<BattelField, BattelFieldModel>()
                .ForMember(bm => bm.Id, m => m.MapFrom(b => b.Id))
                .ForMember(bm => bm.Field, m => m.MapFrom(b => b.Field));
                cfg.CreateMap<BattelFieldModel,BattelField>()
                 .ForMember(b => b.Id, m => m.MapFrom(bm => bm.Id))
                .ForMember(b => b.Field, m => m.MapFrom(bm => bm.Field));
                #endregion 
            });
          }
    }
}
