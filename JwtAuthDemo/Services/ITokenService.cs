namespace JwtAuthDemo.Services
{
    public interface ITokenService
    {
        string GenerateToken(string username, List<string> roles);
    }
}
