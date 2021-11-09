namespace Ion.Net
{
    /// <summary>
    /// Models an `IonCollection` as a resource.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CollectionResource<T> : CollectionResource
    { 
    }

    public class CollectionResource : IonCollection, IIonResource
    {
    }
}
