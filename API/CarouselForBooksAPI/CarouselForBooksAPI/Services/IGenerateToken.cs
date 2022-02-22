namespace CarouselForBooksAPI.Services
{
    public interface IGenerateToken<T>
    {
        string CreateToken(T user);
    }
}