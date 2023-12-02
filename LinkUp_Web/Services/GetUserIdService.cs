using System.Security.Claims;
using LinkUp_Web.Repository;
using LinkUp_Web.Repository.IRepository;


namespace LinkUp_Web.Services;

public class GetUserIdService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public GetUserIdService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }
    
    public string GetCurrentUserId()
    {
        var claimsIdentity = (ClaimsIdentity)_httpContextAccessor.HttpContext.User.Identity;
        return claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
    }
}