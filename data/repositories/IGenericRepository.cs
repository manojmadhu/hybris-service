namespace demo_service;

public interface IGenericRepository<T> where T: class{
    void CreateOrder(T request);
    void TrackOrder(T request);
}