﻿using Mappify;
using Mappify_Tests._0_Models;

namespace Mappify_Tests._1_MappingProfiles;

public class ObjectMappingProfile : BaseMappingProfile
{
    public override void CreateMaps(IMappify Mappify)
    {
        Mappify.CreateMap<SourceClass1, DestinationClass>((source1, Mappify) => new DestinationClass
        {
            Id = source1.Id,
            Name = source1.Name,
        });
    }
}