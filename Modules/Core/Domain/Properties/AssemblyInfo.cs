[assembly: StronglyTypedIdDefaults(
    backingType: StronglyTypedIdBackingType.Guid,
    implementations: StronglyTypedIdImplementations.IEquatable | StronglyTypedIdImplementations.IComparable,
    converters: StronglyTypedIdConverter.TypeConverter | StronglyTypedIdConverter.SystemTextJson)]