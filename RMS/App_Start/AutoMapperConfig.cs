using System.Collections.Generic;
using System.Linq;
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
                Course(cfg);
                Semester(cfg);
                ClassRep(cfg);
                Result(cfg);
            });
        }

        public static void Semester(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Semeter, SemesterModel>();
            cfg.CreateMap<SemesterModel, Semeter>();

            cfg.CreateMap<Semeter, SemesterItem>();
            cfg.CreateMap<SemesterItem, Semeter>();
        }

        public static void Course(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Course, CourseModel>();
            cfg.CreateMap<CourseModel, Course>();

            cfg.CreateMap<Course, CourseItem>();
            cfg.CreateMap<CourseItem, Course>();
        }

        public static void Level(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Level, LevelModel>();
            cfg.CreateMap<LevelModel, Level>();

            cfg.CreateMap<Level, LevelItem>().BeforeMap((src, dest) =>
                {
                    //dest.Sections = Mapper.Map<IEnumerable<Section>, List<SectionModel>>(src.Sections).ToList();
                });
            cfg.CreateMap<LevelItem, Level>();
        }

        public static void Section(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Section, SectionModel>();
            cfg.CreateMap<SectionModel, Section>();

            cfg.CreateMap<Section, SectionItem>();
            cfg.CreateMap<SectionItem, Section>();
        }

        public static void User(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<User, UserModel>();
            cfg.CreateMap<UserModel, User>();
            cfg.CreateMap<User, UserItem>();
            cfg.CreateMap<UserItem, User>();
        }

        public static void ClassRep(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AspNetUser, AspNetUserModel>();
            cfg.CreateMap<AspNetUserModel, AspNetUser>();
            cfg.CreateMap<AspNetUser, AspNetUserItem>();
            cfg.CreateMap<AspNetUserItem, AspNetUser>();
        }

        public static void Result(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Result, ResultModel>();
            cfg.CreateMap<ResultModel, Result>();
            cfg.CreateMap<Result, ResultItem>();
            cfg.CreateMap<ResultItem, Result>();
        }
    }
}
