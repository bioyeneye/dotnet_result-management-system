using System.Collections.Generic;
using AutoMapper;
using DataAccess.EF;
using Model.ViewModel;

namespace RMS
{
    public class AutoMapperConfig
    {
        public static void Map()
        {
            Mapper.Initialize(cfg =>
            {
                Level(cfg);
                Section(cfg);
                User(cfg);
            });
        }

        public static void Level(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Level, LevelModel>();
            //cfg.CreateMap<IEnumerable<Level>, IEnumerable<LevelModel>>();
            cfg.CreateMap<LevelModel, Level>();
            //cfg.CreateMap<IEnumerable<LevelModel>, IEnumerable<Level>>();
        }

        public static void Section(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Section, SectionModel>();
            //cfg.CreateMap<IEnumerable<Section>, IEnumerable<SectionModel>>();
            cfg.CreateMap<SectionModel, Section>();
            //cfg.CreateMap<IEnumerable<SectionModel>, IEnumerable<Section>>();
        }

        public static void User(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<User, UserModel>();
            cfg.CreateMap<UserModel, User>();
            cfg.CreateMap<User, UserItem>();
            cfg.CreateMap<UserItem, User>();
            /*cfg.CreateMap<IEnumerable<User>, IEnumerable<UserModel>>();
            cfg.CreateMap<IEnumerable<UserModel>, IEnumerable<User>>();
            cfg.CreateMap<IEnumerable<User>, IEnumerable<UserItem>>();
            cfg.CreateMap<IEnumerable<UserItem>, IEnumerable<User>>();*/
        }
    }
}
