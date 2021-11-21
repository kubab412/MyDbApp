using AutoMapper;
using System.Collections.Generic;

namespace MyDbApp.Domain
{
    public class DtoMapper
    {
        private IMapper mapper;
        public DtoMapper()
        {
            mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<CategoryEntity, CategoryDto>()
             .ReverseMap();
                config.CreateMap<GymEntity, GymDto>()
             .ReverseMap();
                config.CreateMap<RunEntity, RunDto>()
             .ReverseMap();
                config.CreateMap<SwimEntity, SwimDto>()
             .ReverseMap();
                config.CreateMap<WearEntity, WearDto>()
             .ReverseMap();
            }
            ).CreateMapper();
        }
        #region categoryMapper
        public CategoryDto Map(CategoryEntity categoryEntity) => mapper.Map<CategoryDto>(categoryEntity);
        public IEnumerable<CategoryDto> Map(IEnumerable<CategoryEntity> categories) =>
            mapper.Map<IEnumerable<CategoryDto>>(categories);
        public CategoryEntity Map(CategoryDto categoryDto) => mapper.Map<CategoryEntity>(categoryDto);
        public IEnumerable<CategoryEntity> Map(IEnumerable<CategoryDto> categories) =>
            mapper.Map<IEnumerable<CategoryEntity>>(categories);
        #endregion
        #region gymMapper
        public GymDto Map(GymEntity gymEntity) => mapper.Map<GymDto>(gymEntity);
        public IEnumerable<GymDto> Map(IEnumerable<GymEntity> gyms) =>
            mapper.Map<IEnumerable<GymDto>>(gyms);
        public GymEntity Map(GymDto gymDto) => mapper.Map<GymEntity>(gymDto);
        public IEnumerable<GymEntity> Map(IEnumerable<GymDto> gyms) =>
            mapper.Map<IEnumerable<GymEntity>>(gyms);
        #endregion
        #region swimMapper
        public SwimDto Map(SwimEntity swimEntity) => mapper.Map<SwimDto>(swimEntity);
        public IEnumerable<SwimDto> Map(IEnumerable<SwimEntity> swims) =>
            mapper.Map<IEnumerable<SwimDto>>(swims);
        public SwimEntity Map(SwimDto swimDto) => mapper.Map<SwimEntity>(swimDto);
        public IEnumerable<SwimEntity> Map(IEnumerable<SwimDto> swims) =>
            mapper.Map<IEnumerable<SwimEntity>>(swims);
        #endregion
        #region runMapper
        public RunDto Map(RunEntity runEntity) => mapper.Map<RunDto>(runEntity);
        public IEnumerable<RunDto> Map(IEnumerable<RunEntity> runs) =>
            mapper.Map<IEnumerable<RunDto>>(runs);
        public RunEntity Map(RunDto runDto) => mapper.Map<RunEntity>(runDto);
        public IEnumerable<RunEntity> Map(IEnumerable<RunDto> runs) =>
            mapper.Map<IEnumerable<RunEntity>>(runs);
        #endregion
        #region wearMapper
        public WearDto Map(WearEntity wearEntity) => mapper.Map<WearDto>(wearEntity);
        public IEnumerable<WearDto> Map(IEnumerable<WearEntity> wears) =>
            mapper.Map<IEnumerable<WearDto>>(wears);
        public WearEntity Map(WearDto wearDto) => mapper.Map<WearEntity>(wearDto);
        public IEnumerable<WearEntity> Map(IEnumerable<WearDto> wears) =>
            mapper.Map<IEnumerable<WearEntity>>(wears);
        #endregion
    }
}
